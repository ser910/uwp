using System.Runtime.Serialization;

namespace SeaBattle
{
    public interface ISerializable
    {
        void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}