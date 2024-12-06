namespace Axolotl;

using Items;

public class SmithingTrimRecipe : Recipe
    {
        public SmithingTrimRecipe()
            {
            }

        public SmithingTrimRecipe(string recipeid, Item output, Item template, Item input, Item addition,
            string block) : this()
            {
                RecipeId = recipeid;
                Output = output;
                Template = template;
                Input = input;
                Addition = addition;
                Block = block;
            }

        public string RecipeId { get; set; }
        public int UniqueId { get; set; }
        public Item Template { get; set; }
        public Item Input { get; set; }
        public Item Addition { get; set; }
        public Item Output { get; set; }
    }