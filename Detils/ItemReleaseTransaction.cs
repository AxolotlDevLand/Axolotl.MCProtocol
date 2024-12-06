namespace Axolotl;

using System.Numerics;
using Items;
using MCProtocol.Packet;

public class ItemReleaseTransaction : Transaction
    {
        public McpeInventoryTransaction.ItemReleaseAction ActionType { get; set; }
        public int Slot { get; set; }
        public Item Item { get; set; }
        public Vector3 FromPosition { get; set; }
    }