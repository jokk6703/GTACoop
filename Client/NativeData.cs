using System.Collections.Generic;
using ZeroFormatter;

namespace GTACoOp
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
        public virtual string Identifier { get; set; }
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
    public enum NativeType
    {
        IntArgument,
        UIntArgument,
        StringArgument,
        FloatArgument,
        BooleanArgument,
        LocalPlayerArgument,
        Vector3Argument,
        LocalGamePlayerArgument
    }

    // TODO: Test this
    [Union(typeof(IntArgument),
        typeof(UIntArgument),
        typeof(StringArgument),
        typeof(FloatArgument),
        typeof(BooleanArgument),
        typeof(LocalPlayerArgument),
        typeof(Vector3Argument),
        typeof(LocalGamePlayerArgument))]
    public abstract class NativeArgument
    {
        [UnionKey]
        public abstract NativeType Type { get; }

        [Index(1)]
        public virtual string Id { get; set; }
    }

    [ZeroFormattable]
    public class IntArgument : NativeArgument
    {
        public override NativeType Type => NativeType.IntArgument;
        [Index(2)]
        public virtual int Data { get; set; }
    }
    [ZeroFormattable]
    public class UIntArgument : NativeArgument
    {
        public override NativeType Type => NativeType.UIntArgument;
        [Index(2)]
        public virtual uint Data { get; set; }
    }
    [ZeroFormattable]
    public class StringArgument : NativeArgument
    {
        public override NativeType Type => NativeType.StringArgument;
        [Index(2)]
        public virtual string Data { get; set; }
    }
    [ZeroFormattable]
    public class FloatArgument : NativeArgument
    {
        public override NativeType Type => NativeType.FloatArgument;
        [Index(2)]
        public virtual float Data { get; set; }
    }
    [ZeroFormattable]
    public class BooleanArgument : NativeArgument
    {
        public override NativeType Type => NativeType.BooleanArgument;
        [Index(2)]
        public virtual bool Data { get; set; }
    }
    [ZeroFormattable]
    public class LocalPlayerArgument : NativeArgument
    {
        public override NativeType Type => NativeType.LocalPlayerArgument;
    }

    [ZeroFormattable]
    public class Vector3Argument : NativeArgument
    {
        public override NativeType Type => NativeType.Vector3Argument;
        [Index(2)]
        public virtual float X { get; set; }
        [Index(3)]
        public virtual float Y { get; set; }
        [Index(4)]
        public virtual float Z { get; set; }
    }

    [ZeroFormattable]
    public class LocalGamePlayerArgument : NativeArgument
    {
        public override NativeType Type => NativeType.LocalGamePlayerArgument;
    }
}