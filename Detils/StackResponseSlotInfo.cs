namespace Axolotl;

public class StackResponseSlotInfo
    {
        public byte Slot { get; set; }
        public byte HotbarSlot { get; set; }
        public byte Count { get; set; }
        public int StackNetworkId { get; set; }
        public string CustomName { get; set; }
        public int DurabilityCorrection { get; set; }
    }