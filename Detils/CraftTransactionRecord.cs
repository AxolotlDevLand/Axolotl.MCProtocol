namespace Axolotl;

using MCProtocol.Packet;

public class CraftTransactionRecord : TransactionRecord
    {
        public McpeInventoryTransaction.CraftingAction Action { get; set; }
    }