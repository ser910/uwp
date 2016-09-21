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
        
        public Tank(double X, double Y, double Width = 1, double Height = 1, double Health = 1, bool IsVisible = true, bool IsTransparante = false, bool IsCanBeDestroyed = true, Direction Direction = Direction.Center, double Speed = 1)
            :base(X,Y,Width,Health,Health,IsVisible,IsTransparante,IsCanBeDestroyed,Direction)
        {
            this._speed = Speed;
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
