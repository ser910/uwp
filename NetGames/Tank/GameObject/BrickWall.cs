using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.GameObject
{
    public class BrickWall : Wall
    {
        public BrickWall(int X, int Y)
            : base(X, Y)
        {
            this._type = "BrickWall";
        }
    }
}
