using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace IGame
{
    interface IMap: ISerializable
    {
        //Размер карты
        int X { get; }
        int Y { get; }

        List<IGameObject> GameObjects { get; }


    }
}
