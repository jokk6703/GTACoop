using ZeroFormatter;

namespace GTAServer.ProtocolMessages
{
    [ZeroFormattable]
    public class Quaternion {
        [Index(1)]
        public virtual float X { get; set; }
        [Index(2)]
        public virtual float Y { get; set; }
        [Index(3)]
        public virtual float Z { get; set; }
        [Index(4)]
        public virtual float W { get; set; }
    }
}