namespace Axolotl;

using Items;

public abstract class TransactionRecord
    {
        public int StackNetworkId { get; set; }

        public int Slot { get; set; }
        public Item OldItem { get; set; }
        public Item NewItem { get; set; }
    }