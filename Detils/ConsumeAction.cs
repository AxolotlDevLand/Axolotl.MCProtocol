namespace Axolotl;

public class ConsumeAction : ItemStackAction
    {
        public byte Count { get; set; }
        public StackRequestSlotInfo Source { get; set; }
    }