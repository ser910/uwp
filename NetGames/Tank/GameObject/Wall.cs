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
        protected string _type;
        public string Type { get { return _type; } }

        protected int _x;
        protected int _y;
        public int X { get { return _x; } }
        public int Y { get { return _y; } }

        protected string status;
        public string Status { get { return status; } }

        public Wall(int X, int Y)
        {
            this._type = "Wall";

            this._x = X;
            this._y = Y;

            status = "created";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
