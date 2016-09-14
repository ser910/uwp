using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using IGame;

namespace Tank
{
    public class Map : IMap
    {
        protected List<IGameObject> _gameObjects;
        public List<IGameObject> GameObjects { get { return _gameObjects; } }

        protected int _x;
        protected int _y;
        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        
        public Map(int X, int Y)
        {
            this._x = X;
            this._y = Y;

            _gameObjects = new List<IGameObject>();
        }

        public ITankGameObject AddGameObject(ITankGameObject NewObject)
        {
            foreach(ITankGameObject item in _gameObjects)
            {
                if(Collision(item,NewObject) && item.Transparante == false && NewObject.Transparante == false)
                {
                    return null;
                }                
            }

            _gameObjects.Add(NewObject);
            return NewObject;
        }

        private bool Collision(ITankGameObject firstObject, ITankGameObject secondObject)
        {
            if (firstObject.X == secondObject.X && firstObject.Y == secondObject.Y)
                return true;
            else
                return false;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
