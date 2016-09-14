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
        bool Save();
        bool Load();

        DateTime CheckLastSave();

        string CheckResolution();
        string CheckOperationSystem();
    }
}
