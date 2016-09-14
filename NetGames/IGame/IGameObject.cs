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
        string Type { get; }

        int X { get; }
        int Y { get; }
    }
}
