namespace Axolotl;

using System.Numerics;
using Items;
using MCProtocol.Packet;
using Util;

public class ItemUseTransaction : Transaction
    {
        public McpeInventoryTransaction.ItemUseAction ActionType { get; set; }
        public McpeInventoryTransaction.TriggerType TriggerType { get; set; }
        public BlockCoordinates Position { get; set; }
        public int Face { get; set; }
        public int Slot { get; set; }
        public Item Item { get; set; }
        public Vector3 FromPosition { get; set; }
        public Vector3 ClickPosition { get; set; }
        public uint BlockRuntimeId { get; set; }
        public uint ClientPredictedResult { get; set; }
    }