using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TankGame.GameObject
{

    public enum Direction { Top, Bottom, Left, Right, Non }

    public enum Status { Created, Deleted, Stay, Move, Shot, Wounded, Healed }

    public interface IGameObject: ISerializable
    {
        Type Type { get; }

        string Name { get; }
        
        double X { get; }
        double Y { get; }
        
        double Width { get; }
        double Height { get; }
        
        double Health { get; }
        double Speed { get; }

        bool IsVisible { get; }
        bool IsTransparante { get; }
        bool IsCanBeDestroyed { get; }

        bool IsMove { get; }
        bool IsAI { get; }
        bool IsPlayer { get; }

        double Left { get; }
        double Right { get; }
        double Top { get; }
        double Bottom { get; }
        
        Direction Direction { get; }

        Status Status { get; }

        bool Move(Direction Direction, Map.Map Map);

    }
}
