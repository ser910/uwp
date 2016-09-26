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
        private List<Map.Map> _maps;
        public List<Map.Map> Maps { get { return _maps; } }

        private Map.Map _currentMap;
        public Map.Map CurrentMap { get { return _currentMap; } }

        private Tank _player;
        public Tank Player { get { return _player; } }

        public Game()
        {

        }

        public Map.Map Play(Direction Direction, GameObject.Action Action)
        {
            foreach (var GameObject in _currentMap.GameObjects)
            {
                if (GameObject.Type is Tank && GameObject.IsMove)
                {
                    if (GameObject.IsPlayer)
                    {
                        _currentMap.MoveTank((Tank)GameObject, Direction);

                        if (Action == TankGame.GameObject.Action.Shot)
                            ((Tank)GameObject).Shot();

                    }
                    else if (GameObject.IsAI)
                    {
                        ((Tank)GameObject).AIMove(CurrentMap);
                    }
                }
                else if (GameObject.Type is Bullet && GameObject.IsMove)
                {
                    ((Bullet)GameObject).Move();
                }
            }

            return CurrentMap;
        }

        public bool AddMap(Map.Map Map)
        {
            if (!ValidationMap(Map))
                return false;

            if (_maps == null)
            {
                _maps = new List<TankGame.Map.Map>();
            }

            _maps.Add(Map);

            if (_currentMap == null)
                _currentMap = _maps.FirstOrDefault();

            return true;
        }

        private bool ValidationMap(Map.Map Map)
        {
            if (Map == null || Map.Width < 0 || Map.Height < 0)
                return false;

            return true;
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
