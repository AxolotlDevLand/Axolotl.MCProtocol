namespace Axolotl;

using Items;

public class ShapedRecipe : Recipe
    {
        public ShapedRecipe(int width, int height)
            {
                Width = width;
                Height = height;
                Input = new Item[Width * height];
                Result = new List<Item>();
            }

        public ShapedRecipe(int width, int height, Item result, Item[] input, string block = null) : this(width, height)
            {
                Result.Add(result);
                Input = input;
                Block = block;
            }

        public ShapedRecipe(int width, int height, List<Item> result, Item[] input, string block = null) : this(width,
            height)
            {
                Result = result;
                Input = input;
                Block = block;
            }

        public int UniqueId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Item[] Input { get; set; }
        public List<Item> Result { get; set; }
    }