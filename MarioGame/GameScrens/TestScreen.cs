using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using MarioGame.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioGame.GameScrens
{
    public class TestScreen : GameScreen
    {
        public TestScreen(DoubleGameEngine.Game game) : base(game)
        {

        }

        public override void Initialize()
        {
            base.Initialize();  

            GameObjects.Add("Mario", new Mario(this));
        }
    }
}
