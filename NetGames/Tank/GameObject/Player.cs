using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.GameObject
{
    public class Player : Tank
    {
        public Player(double X, double Y, double Speed = 1, double Health = 1, Direction Direction = Direction.Center, double Width = 1, double Height = 1, bool IsVisible = true, bool IsTransparante = false, bool IsCanBeDestroyed = true)
            : base(X, Y, Speed, Health, Direction, Width, Height, IsVisible, IsTransparante, IsCanBeDestroyed)
        {

        }
    }
}
