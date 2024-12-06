namespace Axolotl;

using System.Numerics;
using Items;
using MCProtocol.Packet;

public class ItemUseOnEntityTransaction : Transaction
    {
        public long EntityId { get; set; }
        public McpeInventoryTransaction.ItemUseOnEntityAction ActionType { get; set; }
        public int Slot { get; set; }
        public Item Item { get; set; }
        public Vector3 FromPosition { get; set; }
        public Vector3 ClickPosition { get; set; }
    }