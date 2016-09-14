using IGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public interface ITankGameObject : IGameObject
    {
        //Проходимость объекта другими объектами
        bool Transparante { get; }
    }
}
