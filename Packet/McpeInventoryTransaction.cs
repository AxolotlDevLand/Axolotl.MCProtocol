namespace Axolotl.MCProtocol.Packet;

public partial class McpeInventoryTransaction
    {
        public enum TriggerType
            {
                Unknown = 0,
                PlayerInput = 1,
                SimulationTick = 2
            }
    }