using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Tank.Map;
using Tank.GameObject;

namespace Tank
{
    class Game : ISerializable
    {
        private IMap _currentMap;
        public IMap CurrentMap { get { return _currentMap; } }

        public IMap Play()
        {
            return CurrentMap;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
