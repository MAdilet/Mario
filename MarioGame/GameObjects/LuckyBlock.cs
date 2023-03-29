using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioGame.GameObjects
{
    public class LuckyBlock : GameObject
    {
        public bool IsMushroom { get; set; }

        public LuckyBlock(GameScreen context) : base(context)
        {

        }
    }
}
