using DoubleGameEngine.GameObjects;
using MarioGame.GameScrens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MarioGame
{
    public class MarioGame : DoubleGameEngine.Game
    {
        public MarioGame()
        {

        }

        protected override void Initialize()
        {
            ScreenManager.LoadScreen(new Level_1(this));
            base.Initialize();
        }
        

        protected override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}