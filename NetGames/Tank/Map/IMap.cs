using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Tank.GameObject;

namespace Tank.Map
{
    public interface IMap : ISerializable
    {
        List<IGameObject> GameObjects { get; }
        
        double Width { get; }
        double Height { get; }
    }
}
