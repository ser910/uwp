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
        public string Type { get { return _type; } }

        protected double _x;
        protected double _y;
        public double X { get { return _x; } }
        public double Y { get { return _y; } }

        protected double _width;
        protected double _height;
        public double Width { get { return _width; } }
        public double Height { get { return _height; } }

        protected double _health;
        public double Health { get { return _health; } }

        protected bool _isVisible;
        public bool IsVisible { get { return _isVisible; } }
        protected bool _isTransparante;
        public bool IsTransparante { get { return _isTransparante; } }
        protected bool _isCanBeDestroyed;
        public bool IsCanBeDestroyed { get { return _isCanBeDestroyed; } }

        public double Left { get { return (X - (Width / 2)); } }
        public double Right { get { return (X + (Width / 2)); } }
        public double Top { get { return (Y - (Height / 2)); } }
        public double Bottom { get { return (Y + (Height / 2)); } }

        protected Direction _direction;
        public Direction Direction { get { return _direction; } }

        protected string _status;
        public string Status { get { return _status; } }

        public GameObject()
        {
            this._type = "GameObject";

            this._x = 0;
            this._y = 0;

            this._width = 1;
            this._height = 1;

            this._health = 1;

            this._isVisible = true;
            this._isTransparante = true;
            this._isCanBeDestroyed = false;

            this._direction = Direction.Center;

            this._status = "Created";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
