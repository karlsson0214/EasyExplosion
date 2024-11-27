using EasyMonoGame;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

using Microsoft.Xna.Framework;
namespace EasyExplosion
{
    internal class Bomb : Actor
    {
        private float time = 0;

        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            time += deltaTime;

            if (time > 2)
            {
                World.Add(new Explosion(), "explosion", X, Y);
                World.RemoveActor(this);
            }

        }
    }
}