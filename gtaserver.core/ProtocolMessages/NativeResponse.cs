using System.Collections.Generic;

using ZeroFormatter;

// I'm just going to keep any natives-related code here.
namespace GTAServer.ProtocolMessages
{
    [ZeroFormattable]
    public class NativeResponse
    {
        [Index(1)]
        public virtual NativeArgument Response { get; set; }
        [Index(2)]
        public virtual string Id { get; set; }
    }

    [ZeroFormattable]
    public class NativeTickCall
    {
        [Index(1)]
        public virtual NativeData Native { get; set; }
        [Index(2)]
        public virtual string Id { get; set; }
    }

    [ZeroFormattable]
    public class NativeData
    {
        [Index(1)]
        public virtual ulong Hash { get; set; }
        [Index(2)]
        public virtual List<NativeArgument> Arguments { get; set; }
        [Index(3)]
        public virtual NativeArgument ReturnType { get; set; }
        [Index(4)]
        public virtual string Id { get; set; }
    }

    [ZeroFormattable]
    // TODO: ZeroFormatter.UnionAttribute on these
    /*
    [ProtoInclude(2, typeof(IntArgument))]
    [ProtoInclude(3, typeof(UIntArgument))]
    [ProtoInclude(4, typeof(StringArgument))]
    [ProtoInclude(5, typeof(FloatArgument))]
    [ProtoInclude(6, typeof(BooleanArgument))]
    [ProtoInclude(7, typeof(LocalPlayerArgument))]
    [ProtoInclude(8, typeof(Vector3Argument))]
    [ProtoInclude(9, typeof(LocalGamePlayerArgument))]*/
    public class NativeArgument
    {
        [Index(1)]
        public virtual string Id { get; set; }
    }

    [ZeroFormattable]
    public class IntArgument : NativeArgument
    {
        [Index(1)]
        public virtual int Data { get; set; }
    }

    [ZeroFormattable]
    public class UIntArgument : NativeArgument
    {
        [Index(1)]
        public virtual uint Data { get; set; }
    }

    [ZeroFormattable]
    public class StringArgument : NativeArgument
    {
        [Index(1)]
        public virtual string Data { get; set; }
    }

    [ZeroFormattable]
    public class FloatArgument : NativeArgument
    {
        [Index(1)]
        public virtual float Data { get; set; }
    }

    [ZeroFormattable]
    public class BooleanArgument : NativeArgument
    {
        [Index(1)]
        public virtual bool Data { get; set; }
    }

    [ZeroFormattable]
    public class Vector3Argument : NativeArgument
    {
        [Index(1)]
        public virtual float X { get; set; }
        [Index(2)]
        public virtual float Y { get; set; }
        [Index(3)]
        public virtual float Z { get; set; }
    }

    [ZeroFormattable]
    public class LocalPlayerArgument : NativeArgument
    {        
    }

    [ZeroFormattable]
    public class LocalGamePlayerArgument : NativeArgument
    {
    }
}
