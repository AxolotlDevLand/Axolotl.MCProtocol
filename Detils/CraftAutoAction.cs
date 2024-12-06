namespace Axolotl;

using Items;

public class CraftAutoAction : ItemStackAction
    {
        public uint RecipeNetworkId { get; set; }
        public byte TimesCrafted { get; set; }
        public byte TimesCrafted2 { get; set; }
        public List<Item> Ingredients { get; set; } = new();
    }