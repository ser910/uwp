using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Tank.GameObject.Interface;

namespace Tank.GameObject.Abstract
{

    public abstract class GameObject : IGameObject
    {
        protected string _type;
        public string Type { get; }

        protected double _x;
        protected double _y;
        public double X { get; }
        public double Y { get; }

        protected double _width;
        protected double _height;
        public double Width { get { return _width; } }
        public double Height { get { return _height; } }

        protected double _health;
        public double Health { get; }

        protected bool _transparante;
        public bool Transparante { get; }
        protected bool _canBeDestroyed;
        public bool CanBeDestroyed { get; }

        public double Left { get { return (X - (Width / 2)); } }
        public double Right { get { return (X + (Width / 2)); } }
        public double Top { get { return (Y - (Height / 2)); } }
        public double Bottom { get { return (Y + (Height / 2)); } }

        protected string _status;
        public string Status { get; }

        public GameObject()
        {
            this._type = "GameObject";

            this._x = 0;
            this._y = 0;

            this._health = 1;

            this._transparante = true;
            this._canBeDestroyed = false;

            this._status = "Created";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
