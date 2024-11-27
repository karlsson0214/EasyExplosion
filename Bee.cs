using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

using Microsoft.Xna.Framework;

namespace EasyExplosion
{
    internal class Bee : Actor
    {
        private float time = 0;
        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            Move(deltaTime * 500);
            time += deltaTime;

            if (time > 0.7)
            {
                Turn(70);
                time = 0;
                World.Add(new Bomb(), "bomb", X, Y);
            }

        }
    }
}
