namespace Axolotl;

public class EntityLink
    {
        public enum EntityLinkType : byte
            {
                Remove = 0,
                Rider = 1,
                Passenger = 2
            }

        public EntityLink(long fromEntityId, long toEntityId, EntityLinkType type, bool immediate, bool causedByRider,
            float vehicleAngularVelocity)
            {
                FromEntityId = fromEntityId;
                ToEntityId = toEntityId;
                Type = type;
                Immediate = immediate;
                CausedByRider = causedByRider;
                VehicleAngularVelocity = vehicleAngularVelocity;
            }

        public long FromEntityId { get; set; }
        public long ToEntityId { get; set; }
        public EntityLinkType Type { get; set; }
        public bool Immediate { get; set; }
        public bool CausedByRider { get; set; }
        public float VehicleAngularVelocity { get; set; }
    }