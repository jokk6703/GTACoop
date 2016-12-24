using System.Collections.Generic;
using ZeroFormatter;

namespace GTAServer.ProtocolMessages
{
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
        public virtual Vector3 Position { get; set; }
        [Index(8)]
        public virtual Quaternion Quaternion { get; set; }
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
}
