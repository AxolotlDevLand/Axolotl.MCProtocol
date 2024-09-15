using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using fNbt;

namespace Axolotl.Items
{
    public enum ItemMaterial
    {
        //Armor Only
        Leather = -2,
        Chain = -1,

        None = 0,
        Wood = 1,
        Stone = 2,
        Gold = 3,
        Iron = 4,
        Diamond = 5,
        Netherite = 6
    }

    public enum ItemType
    {
        //Tools
        Sword,
        Bow,
        Shovel,
        PickAxe,
        Axe,
        Item,
        Hoe,
        Sheers,
        FlintAndSteel,
        Elytra,
        Trident,
        CarrotOnAStick,
        FishingRod,
        Book,

        //Armor
        Helmet,
        Chestplate,
        Leggings,
        Boots
    }

    public enum ItemDamageReason
    {
        BlockBreak,
        BlockInteract,
        EntityAttack,
        EntityInteract,
        ItemUse,
    }
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
}
