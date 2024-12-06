namespace Axolotl;

using Items;

public class CraftResultDeprecatedAction : ItemStackAction
    {
        public ItemStacks ResultItems { get; set; } = new();
        public byte TimesCrafted { get; set; }
    }