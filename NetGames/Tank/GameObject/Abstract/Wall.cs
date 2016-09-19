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
            :base(X,Y)
        {
            this._type = "Wall";

            this._transparante = false;
        }
    }
}
