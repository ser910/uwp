using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.GameObject.Abstract;

namespace Tank.GameObject
{
    public class ConcreteWall: Wall
    {
        public ConcreteWall(int X, int Y)
            : base(X, Y)
        {
            this._type = "ConcreteWall";
        }
    }
}
