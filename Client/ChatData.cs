using ZeroFormatter;

namespace GTACoOp
{
    [ZeroFormattable]
    public class ChatData
    {
        [Index(1)]
        public virtual long Id { get; set; }
        [Index(2)]
        public virtual string Sender { get; set; }
        [Index(3)]
        public virtual string Message { get; set; }
    }
}