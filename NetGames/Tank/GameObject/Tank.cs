using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankGame.Map;

namespace TankGame.GameObject
{
    public class Tank : GameObject
    {
        protected double _speed;
        public double Speed { get { return _speed; } }

        public Tank(double X, double Y, double Speed = 1, double Health = 1, Direction Direction = Direction.Non, bool IsAI = false, bool IsPlayer = false, double Width = 1, double Height = 1, bool IsMove = true, bool IsVisible = true, bool IsTransparante = false, bool IsCanBeDestroyed = true)
            : base(X, Y, Width, Health, Health, IsVisible, IsTransparante, IsCanBeDestroyed, IsMove, IsAI, IsPlayer, Direction)
        {
            this._speed = Speed;
        }

        public void Move(Direction NewDirection)
        {
            switch (this.Direction)
            {
                case Direction.Top:
                    this._status = Status.Move;
                    this._direction = NewDirection;
                    this._y -= this._speed;
                    break;
                case Direction.Bottom:
                    this._status = Status.Move;
                    this._direction = NewDirection;
                    this._y += this._speed;
                    break;
                case Direction.Left:
                    this._status = Status.Move;
                    this._direction = NewDirection;
                    this._x -= this._speed;
                    break;
                case Direction.Right:
                    this._status = Status.Move;
                    this._direction = NewDirection;
                    this._x += this._speed;
                    break;
                case Direction.Non:
                    break;
                default:
                    break;
            }
        }

        public void MoveBack(Direction NewDirection)
        {
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
                case Direction.Non:
                    break;
                default:
                    break;
            }
        }

        public void AIMove(Map.Map Map)
        {

        }

        public Bullet Shot()
        {
            return new Bullet(this.X, this.Y, this.Direction);
        }

    }
}
