using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using DoubleGameEngine.Managers;
using MarioGame.GameScrens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarioGame.GameObjects
{
    /// <summary>
    /// Марио
    /// </summary>
    public class Mario : GameObject
    {
        public MarioType Type { get; set; } //Тип Марио
        public float Speed { get; set; } //Скорость

        private Vector2 _velocity = new Vector2(); //Передвижение

        public Mario(GameScreen context) : base(context)
        {

        }

        public override void Init()
        {
            Texture = Context.Content.Load<Texture2D>("GameObjects/s_Mario");
            Type = MarioType.DEFAULT;

            base.Init();

            Scale = Vector2.One * 0.1f;
            Size = new Vector2(Texture.Width, Texture.Height);
        }

        public override void Update(float elapsedTime)
        {
            Move(elapsedTime);

            base.Update(elapsedTime);
        }

        /// <summary>
        /// Движение Марио
        /// </summary>
        /// <param name="elapsedTime">Время между кадрами<param>
        public void Move(float elapsedTime)
        {
            int moveRight;
            int moveLeft;

            bool keyRight = Keyboard.IsKeyDown(_input["Right"]);
            bool keyLeft = Keyboard.IsKeyDown(_input["Left"]);

            if (keyRight) moveRight = 1; else moveRight = 0;
            if (keyLeft) moveLeft = 1; else moveLeft = 0;

            _velocity.X = moveRight - moveLeft;
            new Vector2 (Position.X + _velocity.X * Speed * elapsedTime, Position.Y);

            Position += _velocity;
        }

    }
    public enum MarioType
    {
        DEFAULT,
        BIGGER,
        FIREBALL,
        STAR
        
    }

}
