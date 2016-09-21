using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.GameObject
{
    public class Tank: GameObject
    {
        protected double _speed;
        public double Speed { get { return _speed; } }

        public Tank(double X, double Y)
        {
            this._x = X;
            this._y = Y;

            this._width = 1;
            this._height = 1;

            this._health = 1;

            this._isVisible = true;
            this._isTransparante = false;
            this._isCanBeDestroyed = true;

            this._direction = Direction.Center;

            this._status = Status.Created;

            this._speed = 1;
        }

        public void Move(Direction NewDirection)
        {
            this._status = Status.Move;

            this._direction = NewDirection;

            switch (this.Direction)
            {
                case Direction.Top:
                    this._y -= this._speed;
                    break;
                case Direction.Bottom:
                    this._y += this._speed;
                    break;
                case Direction.Left:
                    this._x -= this._speed;
                    break;
                case Direction.Right:
                    this._x += this._speed;
                    break;
                case Direction.Center:
                    break;
                default:
                    break;
            }
        }

        public void MoveBack(Direction NewDirection)
        {
            this._direction = NewDirection;

            switch (this.Direction)
            {
                case Direction.Top:
                    this._y += this._speed;
                    break;
                case Direction.Bottom:
                    this._y -= this._speed;
                    break;
                case Direction.Left:
                    this._x += this._speed;
                    break;
                case Direction.Right:
                    this._x -= this._speed;
                    break;
                case Direction.Center:
                    break;
                default:
                    break;
            }
        }
    }
}
