using ZeroFormatter;

namespace GTAServer.ProtocolMessages
{
    [ZeroFormattable]
    public class Vector3
    {
        public Vector3()
        {
            X = 0f;
            Y = 0f;
            Z = 0f;
        }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        /// <summary>
        /// X
        /// </summary>
        [Index(1)]
        public virtual float X { get; set; }
        /// <summary>
        /// Y
        /// </summary>
        [Index(2)]
        public virtual float Y { get; set; }
        /// <summary>
        /// Z
        /// </summary>
        [Index(3)]
        public virtual float Z { get; set; }
    }
}
