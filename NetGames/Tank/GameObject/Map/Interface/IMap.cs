using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Tank.GameObject.Interface;

namespace Tank.Map.Interface
{
    public interface IMap : ISerializable
    {
        List<IGameObject> GameObjects { get; }
        
        double Width { get; }
        double Height { get; }
    }
}
