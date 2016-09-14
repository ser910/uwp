using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using IGame;

namespace Tank.GameObject
{
    public abstract class Wall : IGameObject
    {
        protected string type;
        public string Type { get { return type; } }

        protected int x;
        protected int y;
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Wall(int X, int Y)
        {
            this.type = "Wall";

            this.x = X;
            this.y = Y;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
