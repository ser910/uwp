using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tank.GameObject.Interface
{

    public enum Direction { Top, Bottom, Left, Right, Center }

    public interface IGameObject: ISerializable
    {
        Type Type { get; }

        string Name { get; }
        
        double X { get; }
        double Y { get; }
        
        double Width { get; }
        double Height { get; }
        
        double Health { get; }
        
        bool IsVisible { get; }
        bool IsTransparante { get; }
        bool IsCanBeDestroyed { get; }

        double Left { get; }
        double Right { get; }
        double Top { get; }
        double Bottom { get; }
        
        Direction Direction { get; }
        
        string Status { get; }
    }
}
