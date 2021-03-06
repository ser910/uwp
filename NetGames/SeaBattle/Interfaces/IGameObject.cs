﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using SQLite.Net;

namespace SeaBattle
{
    public interface IGameObject: ISerializable<IGameObject>
    {
        //Тип объекта
        Type Type { get; }

        //Положение объекта на карте
        int X { get; }
        int Y { get; }

        //Статус объекта
        string Status { get; }

    }
}
