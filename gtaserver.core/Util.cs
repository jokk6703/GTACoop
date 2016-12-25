using System.IO;
using Microsoft.Extensions.Logging;
using ProtoBuf;

namespace GTAServer
{
    public class Util
    {
        /// <summary>Deprecated. See ZeroFormatterSerializer.Deserialize<I>(byte[])</summary>
        public static T DeserializeBinary<T>(byte[] data)
        {
            using (var stream = new MemoryStream(data))
            {
                return Serializer.Deserialize<T>(stream);
            }
        }

        /// <summary>Deprecated. See ZeroFormatterSerializer.Serialize(object)</summary>
        public static byte[] SerializeBinary(object data)
        {
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, data);
                return stream.ToArray();
            }
        }

        public static ILoggerFactory LoggerFactory;
    }
}
