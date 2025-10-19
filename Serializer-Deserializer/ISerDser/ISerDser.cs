namespace SerDser
{
    /// <summary>
    /// Interface for Serializer-Deserializer
    /// </summary>
    public interface ISerDser
    {
        byte[] Serializer(object inputDataStructure);
        object Deserializer(byte[] inputByteStream);
    }
}
