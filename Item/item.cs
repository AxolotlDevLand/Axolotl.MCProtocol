namespace Axolotl.Items;

using fNbt;

public class Item : ICloneable
    {
        public int UniqueId { get; set; } = Environment.TickCount;
        public string Name { get; protected set; } = string.Empty;
        public short Id { get; protected set; }
        public int NetworkId { get; set; } = -1;
        public int RuntimeId { get; set; }
        public short Metadata { get; set; }
        public byte Count { get; set; }
        public virtual NbtCompound ExtraData { get; set; }
        public ItemMaterial ItemMaterial { get; set; } = ItemMaterial.None;

        public ItemType ItemType { get; set; } = ItemType.Item;

        public int MaxStackSize { get; set; } = 64;

        public bool IsStackable => MaxStackSize > 1;

        public int Durability { get; set; }

        public int FuelEfficiency { get; set; }

        public object Clone()
            {
                throw new NotImplementedException();
            }
    }