using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Tank.GameObject.Interface;

namespace Tank.GameObject.Abstract
{

    public abstract class GameObject : IGameObject
    {
        protected string _type;
        public string Type { get; }

        protected double _x;
        protected double _y;
        public double X { get; }
        public double Y { get; }

        protected double _health;
        public double Health { get; }

        protected bool _transparante;
        public bool Transparante { get; }
        protected bool _canBeDestroyed;
        public bool CanBeDestroyed { get; }

        protected string _status;
        public string Status { get; }
        
        public GameObject(double X, double Y)
        {
            this._type = "GameObject";

            this._x = X;
            this._y = Y;

            this._health = 1;

            this._transparante = true;
            this._canBeDestroyed = false;

            this._status = "Created";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
