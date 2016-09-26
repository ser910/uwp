using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using TankGame.Map;
using TankGame.GameObject;

namespace TankGame
{
    class Game : ISerializable
    {
        private Map.Map _currentMap;
        public Map.Map CurrentMap { get { return _currentMap; } }

        private Tank _player;
        public Tank Player { get { return _player; } }

        public Game()
        {

        }

        public Map.Map Play(Direction Direction)
        {
            return CurrentMap;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
