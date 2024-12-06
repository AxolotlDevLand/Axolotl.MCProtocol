namespace Axolotl;

public class DestroyAction : ItemStackAction
    {
        public byte Count { get; set; }
        public StackRequestSlotInfo Source { get; set; }
    }