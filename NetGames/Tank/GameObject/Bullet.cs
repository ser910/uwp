using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using IGame;

namespace Tank
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
                return (int)pos.X;
            }
        }

        public int Y
        {
            get
            {
                return (int)pos.Y;
            }
        }

        public string Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Transparante
        {
            get { return false; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
