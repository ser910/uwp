using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Tank.GameObject.Interface;
using Tank.Map.Interface;

namespace Tank.Map
{
    public class Map: IMap
    {
        private List<IGameObject> _gameObjects;
        public List<IGameObject> GameObjects { get { return _gameObjects; } }

        private double _width;
        private double _height;
        public double Width { get { return _width; } }
        public double Height { get { return _height; } }

        public Map(int Width, int Height)
        {
            this._width = Width;
            this._height = Height;

            this._gameObjects = new List<IGameObject>();
        }

        public bool AddObject(IGameObject GameObject)
        {
            if (CollisionInList(GameObject))
                return false;

            this._gameObjects.Add(GameObject);

            return true;
        }

        private bool CollisionInList(IGameObject GameObject)
        {
            foreach(IGameObject GameObjectInList in GameObjects)
            {
                if (Collision(GameObject, GameObjectInList))
                    return true;
            }
            return false;
        }

        private bool Collision(IGameObject first, IGameObject second)
        {
            if (((first.Right >= second.Left && first.Right <= second.Right) || (first.Left <= second.Right && first.Left >= second.Left))
                &&((first.Bottom >= second.Top && first.Bottom <= second.Bottom) || (first.Top <= second.Bottom && first.Top >= second.Top)))
                return true;
            return false;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
