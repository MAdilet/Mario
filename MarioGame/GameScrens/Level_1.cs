using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using DoubleGameEngine.InterfaceItems;
using MarioGame.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MarioGame.GameScrens
{
    public class Level_1 : GameScreen
    {
        public Level_1(DoubleGameEngine.Game game) : base(game)
        {
        }

        public override void Initialize()
        {
            _level = "Level_1";

            base.Initialize();
            InitializeGameObject();
        }

        public void InitializeGameObject()
        {
            foreach (Entity entity in _entities)
            {
                switch (entity.Type)
                {
                    case "LuckyBlock":
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(),
                            new LuckyBlock(this)
                            {
                                Position = new Vector2(entity.X, entity.Y),
                                IsMushroom = ((JsonElement)entity.CustomFields["IsMushroom"]).ValueKind == JsonValueKind.True ? true : false,
                            });
                            break;
                    case "Brick": 
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(),
                            new Brick(this) { Position = new Vector2(entity.X, entity.Y) });
                            break;
                    case "Coin":
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(),
                            new Coin(this) { Position = new Vector2(entity.X, entity.Y) }); 
                            break;
                    case "Finish":
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(),
                            new Finish(this) { Position = new Vector2(entity.X, entity.Y) });
                            break;
                    case "Pipe":
                        GameObjects.Add(entity.Type + "_" + Guid.NewGuid(),
                            new Pipe(this){ Position = new Vector2(entity.X, entity.Y) });
                            break;
                }
            }
        }
    }
}
