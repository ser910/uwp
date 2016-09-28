using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankGame.Map;

namespace TankGame.GameObject
{
    public class Tank : GameObject
    {
        public Tank(double X, double Y, double Speed = 1, double Health = 1, Direction Direction = Direction.Non, bool IsAI = false, bool IsPlayer = false, double Width = 1, double Height = 1, bool IsMove = true, bool IsVisible = true, bool IsTransparante = false, bool IsCanBeDestroyed = true)
            : base(X, Y, Width, Health, Health, Speed, IsVisible, IsTransparante, IsCanBeDestroyed, IsMove, IsAI, IsPlayer, Direction)
        {

        }

        public Bullet Shot()
        {
            return new Bullet(this.X, this.Y, this.Direction);
        }

    }
}
