using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace IGame
{
    interface IGame: ISerializable
    {
        //Сохранение и загрузка уровня, положения объектов и других параметров игры с помощю сереализации
        bool Save();
        bool Load();

        //Проверка последнего сохранения
        DateTime CheckLastSave();

        //Проверка ОС и разрешения экрана
        string CheckResolution();
        string CheckOperationSystem();
    }
}
