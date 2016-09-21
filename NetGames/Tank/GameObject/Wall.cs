using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.GameObject
{
    public class Wall : GameObject
    {
        public Wall(double X, double Y, bool IsCanBeDestroyed = false, double Health = 1, double Width = 1, double Height = 1,  bool IsVisible = true, bool IsTransparante = false, Direction Direction = Direction.Center)
            : base(X, Y, Width, Health, Health, IsVisible, IsTransparante, IsCanBeDestroyed, Direction)
        {

        }
    }
}
