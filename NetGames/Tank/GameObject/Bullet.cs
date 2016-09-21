using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.GameObject
{
    public class Bullet: GameObject
    {
        protected double _speed;
        public double Speed { get { return _speed; } }

        public Bullet(double X, double Y, Direction Direction, double Speed = 2, double Width = 0.1, double Height = 0.1, double Health = 1, bool IsVisible = true, bool IsTransparante = false, bool IsCanBeDestroyed = true)
            : base(X, Y, Width, Health, Health, IsVisible, IsTransparante, IsCanBeDestroyed, Direction)
        {
            this._speed = Speed;
        }
    }
}
