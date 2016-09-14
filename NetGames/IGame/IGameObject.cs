using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace IGame
{
    interface IGameObject: ISerializable
    {
        //Тип объекта
        string Type { get; }

        //Положение объекта на карте
        int X { get; }
        int Y { get; }
    }
}
