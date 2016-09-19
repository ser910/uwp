using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.GameObject.Abstract
{
    public abstract class Tank: GameObject
    {
        public Tank(double X, double Y)
        {
            this._type = "Tank";

            this._x = X;
            this._y = Y;

            this._health = 1;

            this._transparante = false;
            this._canBeDestroyed = true;

            this._status = "Created";
        }
    }
}
