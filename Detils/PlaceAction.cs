namespace Axolotl;

public class PlaceAction : ItemStackAction
    {
        public byte Count { get; set; }
        public StackRequestSlotInfo Source { get; set; }
        public StackRequestSlotInfo Destination { get; set; }
    }