using ZeroFormatter;    

namespace GTAServer.ProtocolMessages
{
    [ZeroFormattable]
    public class PlayerDisconnect
    {
        [Index(1)]
        public long Id { get; set; }
    }
}
