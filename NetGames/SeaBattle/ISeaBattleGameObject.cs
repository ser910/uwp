using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public interface ISeaBattleGameObject: IGameObject
    {
        double Weight { get; set; }
        string Name { get; }
    }
}
