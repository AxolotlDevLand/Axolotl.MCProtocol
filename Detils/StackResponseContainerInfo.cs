namespace Axolotl;

public class StackResponseContainerInfo
    {
        public byte ContainerId { get; set; }
        public int DynamicId { get; set; }
        public List<StackResponseSlotInfo> Slots { get; set; } = new();
    }