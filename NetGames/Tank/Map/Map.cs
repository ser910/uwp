using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TankGame.GameObject;

namespace TankGame.Map
{
    public class Map: ISerializable
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
            if (!Validation(GameObject))
                return false;
            
            if (CollisionInList(GameObject) != null && TransparanteCollision(GameObject, CollisionInList(GameObject)))
                return false;

            this._gameObjects.Add(GameObject);

            return true;
        }

        public bool Validation(IGameObject GameObject)
        {
            if (GameObject == null)
                return false;

            if (GameObject.X <= 0 || GameObject.X > this.Width
                || GameObject.Y <= 0 || GameObject.Y > this.Height)
                return false;

            return true;
        }

        public IGameObject CollisionInList(IGameObject GameObject)
        {
            foreach(IGameObject GameObjectInList in GameObjects)
            {
                if (Collision(GameObject, GameObjectInList))
                    return GameObjectInList;
            }
            return null;
        }

        public bool Collision(IGameObject first, IGameObject second)
        {
            if (((first.Right >= second.Left && first.Right <= second.Right) || (first.Left <= second.Right && first.Left >= second.Left))
                &&((first.Bottom >= second.Top && first.Bottom <= second.Bottom) || (first.Top <= second.Bottom && first.Top >= second.Top)))
                return true;
            return false;
        }

        public bool TransparanteCollision(IGameObject first, IGameObject second)
        {
            if (first == null || second == null)
                return false;

            if (first.IsTransparante || second.IsTransparante)
                return false;

            return true;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
