using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.GameObject
{
    public class Wall : GameObject
    {
        public Wall(double X, double Y, bool IsCanBeDestroyed = false, double Health = 1, double Width = 1, double Height = 1,  bool IsVisible = true, bool IsTransparante = false, bool IsAI = false, Direction Direction = Direction.Non)
            : base(X, Y, Width, Health, Health, IsVisible, IsTransparante, IsCanBeDestroyed, IsAI, Direction)
        {

        }
    }
}
