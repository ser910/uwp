using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using IGame;

namespace Tank.GameObject
{
    public abstract class Bullet : IGameObject
    {
        protected string type;
        protected Vector pos;
        protected Vector speed;
        public Bullet(int x, int y, int speedX, int speedY)
        {
            this.pos = new Vector((double)x, (double)y);
            this.speed = new Vector((double)speedX, (double)speedY);
        }
        public string Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int X
        {
            get
            {
                return pos.X;
            }
        }

        public int Y
        {
            get
            {
                return pos.Y;
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
