namespace Axolotl;

public class DropAction : ItemStackAction
    {
        public byte Count { get; set; }
        public StackRequestSlotInfo Source { get; set; }
        public bool Randomly { get; set; }
    }