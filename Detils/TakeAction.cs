namespace Axolotl;

public class TakeAction : ItemStackAction
    {
        public byte Count { get; set; }
        public StackRequestSlotInfo Source { get; set; }
        public StackRequestSlotInfo Destination { get; set; }
    }