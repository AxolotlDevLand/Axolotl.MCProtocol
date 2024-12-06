namespace Axolotl;

public class SwapAction : ItemStackAction
    {
        public StackRequestSlotInfo Source { get; set; }
        public StackRequestSlotInfo Destination { get; set; }
    }