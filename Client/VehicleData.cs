using System.Collections.Generic;
using GTA.Math;
using NativeUI;
using ProtoBuf;
using ZeroFormatter;

namespace GTACoOp
{
    public enum PacketType
    {
        VehiclePositionData = 0,
        ChatData = 1,
        PlayerDisconnect = 2,
        PedPositionData = 3,
        NpcVehPositionData = 4,
        NpcPedPositionData = 5,
        WorldSharingStop = 6,
        DiscoveryResponse = 7,
        ConnectionRequest = 8,
        NativeCall = 9,
        NativeResponse = 10,
        PlayerKilled = 11,
        NativeTick = 12,
        NativeTickRecall = 13,
        NativeOnDisconnect = 14,
        NativeOnDisconnectRecall = 15,
    }

    public enum ScriptVersion // Please only increment this/add versions on changes that may break the protocol.
    {
        VERSION_UNKNOWN = 0,
        VERSION_0_6 = 1,
        VERSION_0_6_1 = 2,
        VERSION_0_7 = 3,
        VERSION_0_8_1 = 4,
        VERSION_0_9 = 5,
        VERSION_0_9_1 = 6,
        VERSION_0_9_2 = 7,
        VERSION_0_9_3 = 8,
        VERSION_1_0_0 = 9
    }

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

    [ZeroFormattable]
    public class ConnectionRequest
    {
        [Index(1)]
        public virtual string Name { get; set; }

        [Index(2)]
        public virtual string Password { get; set; }

        [Index(3)]
        public virtual string DisplayName { get; set; }

        [Index(4)]
        public virtual int GameVersion { get; set; }

        [Index(5)]
        public virtual byte ScriptVersion { get; set; }
    }

    [ZeroFormattable]
    public class VehicleData
    {
        [Index(1)]
        public virtual long Id { get; set; }
        [Index(2)]
        public virtual string Name { get; set; }

        [Index(3)]
        public virtual int VehicleModelHash { get; set; }
        [Index(4)]
        public virtual int PedModelHash { get; set; }
        [Index(5)]
        public virtual int PrimaryColor { get; set; }
        [Index(6)]
        public virtual int SecondaryColor { get; set; }

        [Index(7)]
        public virtual LVector3 Position { get; set; }
        [Index(8)]
        public virtual LQuaternion Quaternion { get; set; }

        [Index(9)]
        public virtual int VehicleSeat { get; set; }

        [Index(10)]
        public virtual int VehicleHealth { get; set; }

        [Index(11)]
        public virtual int PlayerHealth { get; set; }

        [Index(12)]
        public virtual float Latency { get; set; }

        [Index(13)]
        public virtual Dictionary<int, int> VehicleMods { get; set; }

        [Index(14)]
        public virtual bool IsPressingHorn { get; set; }

        [Index(15)]
        public virtual bool IsSirenActive { get; set; }

        [Index(16)]
        public virtual float Speed { get; set; }
    }

    [ZeroFormattable]
    public class PedData
    {
        [Index(1)]
        public virtual long Id { get; set; }
        [Index(2)]
        public virtual string Name { get; set; }

        [Index(3)]
        public virtual int PedModelHash { get; set; }

        [Index(4)]
        public virtual LVector3 Position { get; set; }
        [Index(5)]
        public virtual LQuaternion Quaternion { get; set; }

        [Index(6)]
        public virtual bool IsJumping { get; set; }
        [Index(7)]
        public virtual bool IsShooting { get; set; }
        [Index(8)]
        public virtual bool IsAiming { get; set; }
        [Index(9)]
        public virtual LVector3 AimCoords { get; set; }
        [Index(10)]
        public virtual int WeaponHash { get; set; }

        [Index(11)]
        public virtual int PlayerHealth { get; set; }

        [Index(12)]
        public virtual float Latency { get; set; }

        [Index(13)]
        public virtual Dictionary<int, int> PedProps { get; set; }

        [Index(14)]
        public virtual bool IsParachuteOpen { get; set; }
    }

    [ZeroFormattable]
    public class PlayerDisconnect
    {
        [Index(1)]
        public virtual long Id { get; set; }
    }
    
    [ZeroFormattable]
    public class LVector3
    {
        [Index(1)]
        public virtual float X { get; set; }
        [Index(2)]
        public virtual float Y { get; set; }
        [Index(3)]
        public virtual float Z { get; set; }

        public virtual Vector3 ToVector()
        {
            return new Vector3(X, Y, Z);
        }
    }

    [ZeroFormattable]
    public class LQuaternion
    {
        [Index(1)]
        public virtual float X { get; set; }
        [Index(2)]
        public virtual float Y { get; set; }
        [Index(3)]
        public virtual float Z { get; set; }
        [Index(4)]
        public virtual float W { get; set; }

        public virtual Quaternion ToQuaternion()
        {
            return new Quaternion(X, Y, Z, W);
        }
    }

    public static class VectorExtensions
    {
        public static LVector3 ToLVector(this Vector3 vec)
        {
            return new LVector3()
            {
                X = vec.X,
                Y = vec.Y,
                Z = vec.Z,
            };
        }

        public static LQuaternion ToLQuaternion(this Quaternion vec)
        {
            return new LQuaternion()
            {
                X = vec.X,
                Y = vec.Y,
                Z = vec.Z,
                W = vec.W,
            };
        }
    }
}