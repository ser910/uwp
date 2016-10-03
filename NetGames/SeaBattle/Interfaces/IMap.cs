using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using SQLite.Net;

namespace SeaBattle
{
    public interface IMap : ISerializable<IMap>
    {
        //Размер карты
        int X { get; }
        int Y { get; }

        //Список объектов на карте
        List<IGameObject> GameObjects { get; }
    }
}
