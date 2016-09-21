using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.GameObject.Interface;

namespace Tank.GameObject.Abstract
{
    public abstract class Wall: GameObject
    {
        public Wall(double X, double Y)
        {
            this._x = X;
            this._y = Y;

            this._width = 1;
            this._height = 1;

            this._health = 1;

            this._isVisible = true;
            this._isTransparante = false;
            this._isCanBeDestroyed = false;

            this._direction = Direction.Center;

            this._status = Status.Created;
        }
    }
}
