namespace Axolotl;

using Items;

public class SmeltingRecipe : Recipe
    {
        public SmeltingRecipe()
            {
                
            }

        public SmeltingRecipe(Item result, Item input, string block = null) : this()
            {
                Result = result;
                Input = input;
                Block = block;
            }

        public Item Input { get; set; }
        public Item Result { get; set; }
    }