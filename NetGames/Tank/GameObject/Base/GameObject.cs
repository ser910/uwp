﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TankGame.GameObject
{

    public abstract class GameObject : IGameObject
    {
        public Type Type { get { return this.GetType(); } }

        private string _name;
        public string Name { get { if (string.IsNullOrEmpty(_name)) { return Type.Name; } else return _name; } }

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
        protected double _speed;
        public double Speed { get { return _speed; } }

        protected bool _isVisible;
        public bool IsVisible { get { return _isVisible; } }
        protected bool _isTransparante;
        public bool IsTransparante { get { return _isTransparante; } }
        protected bool _isCanBeDestroyed;
        public bool IsCanBeDestroyed { get { return _isCanBeDestroyed; } }

        protected bool _isMove;
        public bool IsMove { get { return _isMove; } }
        protected bool _isAI;
        public bool IsAI { get { return _isAI; } }
        protected bool _isPlayer;
        public bool IsPlayer { get { return _isPlayer; } }

        public double Left { get { return (X - (Width / 2)); } }
        public double Right { get { return (X + (Width / 2)); } }
        public double Top { get { return (Y - (Height / 2)); } }
        public double Bottom { get { return (Y + (Height / 2)); } }

        protected Direction _direction;
        public Direction Direction { get { return _direction; } }

        protected Status _status;
        public Status Status { get { return _status; } }

        public GameObject(double X, double Y, double Width = 1, double Height = 1, double Health = 1, double Speed = 0, bool IsVisible = true, bool IsTransparante = false, bool IsCanBeDestroyed = false, bool IsMove = false, bool IsAI = false, bool IsPlayer = false, Direction Direction = Direction.Non)
        {
            this._x = X;
            this._y = Y;

            this._width = Width;
            this._height = Height;

            this._health = Health;
            this._speed = Speed;

            this._isVisible = IsVisible;
            this._isTransparante = IsTransparante;
            this._isCanBeDestroyed = IsCanBeDestroyed;

            this._isMove = IsMove;
            this._isAI = IsAI;
            this._isPlayer = IsPlayer;

            this._direction = Direction;
            
            this._status = Status.Created;
        }

        public bool Move(Direction NewDirection, Map.Map Map)
        {
            this._status = Status.Move;
            this._direction = NewDirection;

            switch (this.Direction)
            {
                case Direction.Top:
                    this._y -= this.Speed;
                    break;
                case Direction.Bottom:
                    this._y += this.Speed;
                    break;
                case Direction.Left:
                    this._x -= this.Speed;
                    break;
                case Direction.Right:
                    this._x += this.Speed;
                    break;
                case Direction.Non:
                    break;
                default:
                    break;
            }

            if (!Map.TransparanteCollision(this,Map.CollisionInList(this)))
                return true;

            switch (this.Direction)
            {
                case Direction.Top:
                    this._y += this.Speed;
                    break;
                case Direction.Bottom:
                    this._y -= this.Speed;
                    break;
                case Direction.Left:
                    this._x += this.Speed;
                    break;
                case Direction.Right:
                    this._x -= this.Speed;
                    break;
                case Direction.Non:
                    break;
                default:
                    break;
            }

            return false;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
