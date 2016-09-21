using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGame;

namespace Tank.GameObject.Abstract
{
    public abstract class Wall: GameObject
    {
        public Wall(double X, double Y)
        {
            this._type = typeof(Wall);

            this._x = X;
            this._y = Y;

            this._width = 1;
            this._height = 1;

            this._transparante = false;
        }
    }
}
