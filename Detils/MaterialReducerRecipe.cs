namespace Axolotl;

public class MaterialReducerRecipe
    {
        public MaterialReducerRecipe()
            {
            }

        public MaterialReducerRecipe(int inputId, int inputMeta, params MaterialReducerRecipeOutput[] outputs)
            {
                Input = inputId;
                InputMeta = inputMeta;

                Output = outputs;
            }

        public int Input { get; set; }
        public int InputMeta { get; set; }

        public MaterialReducerRecipeOutput[] Output { get; set; }

        public class MaterialReducerRecipeOutput
            {
                public MaterialReducerRecipeOutput()
                    {
                    }

                public MaterialReducerRecipeOutput(int itemId, int itemCount)
                    {
                        ItemId = itemId;
                        ItemCount = itemCount;
                    }

                public int ItemId { get; set; }
                public int ItemCount { get; set; }
            }
    }