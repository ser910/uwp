using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace IGame
{
    public interface IGameObject: ISerializable
    {
        //ser910 21.09.16
        //Тип объекта возвращаем не строку с именем класса а конкретный тип класса.
        //например в классе BrickWall свойство Type возвращает typeof(BrickWall)
        //потом из коллекции List<IGameObject> ,будет проще получить конкретный объект
        Type Type { get; }

        //Положение объекта на карте
        double X { get; }
        double Y { get; }

        //Статус объекта
        /// <summary>
        /// bla bla
        /// </summary>
        string Status { get; }



    }
}
