namespace Axolotl;

using Items;

public class ShapelessRecipe : Recipe
    {
        public ShapelessRecipe()
            {
                Input = new List<Item>();
                Result = new List<Item>();
            }

        public ShapelessRecipe(List<Item> result, List<Item> input, string block = null) : this()
            {
                Result = result;
                Input = input;
                Block = block;
            }

        public ShapelessRecipe(Item result, List<Item> input, string block = null) : this()
            {
                Result.Add(result);
                Input = input;
                Block = block;
            }

        public int UniqueId { get; set; }
        public List<Item> Input { get; private set; }
        public List<Item> Result { get; }
    }