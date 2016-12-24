using ZeroFormatter;

namespace GTAServer.ProtocolMessages
{
    [ZeroFormattable]
    public class DiscoveryResponse
    {
        [Index(1)]
        public virtual string ServerName { get; set; }
        [Index(2)]
        public virtual int MaxPlayers { get; set; }
        [Index(3)]
        public virtual int PlayerCount { get; set; }
        [Index(4)]
        public virtual bool PasswordProtected { get; set; }
        [Index(5)]
        public virtual int Port { get; set; }
        [Index(6)]
        public virtual string Gamemode { get; set; }
    }
}
