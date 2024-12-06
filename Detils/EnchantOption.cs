namespace Axolotl;

public class EnchantOption
    {
        public uint Cost { get; set; }
        public int Flags { get; set; }
        public string Name { get; set; }
        public int OptionId { get; set; }

        public List<Enchant> EquipActivatedEnchantments { get; set; } = new();
        public List<Enchant> HeldActivatedEnchantments { get; set; } = new();
        public List<Enchant> SelfActivatedEnchantments { get; set; } = new();
    }