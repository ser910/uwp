using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.GameObject
{
    public class Bullet: GameObject
    {
        public Bullet(double X, double Y, Direction Direction, double Speed = 2, double Width = 0.1, double Height = 0.1, double Health = 1, bool IsVisible = true, bool IsTransparante = false, bool IsMove = true, bool IsAI = true, bool IsPlayer = false, bool IsCanBeDestroyed = true)
            : base(X, Y, Width, Health, Health, Speed, IsVisible, IsTransparante, IsCanBeDestroyed, IsMove, IsAI, IsPlayer, Direction)
        {

        } 

        public void Move()
        {
            this._status = Status.Move;

            this._y -= this._speed;
        }
    }
}
