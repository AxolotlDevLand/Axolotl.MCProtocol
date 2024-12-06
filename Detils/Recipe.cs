namespace Axolotl;

using MCProtocol;

public abstract class Recipe
    {
        public UUID Id { get; set; } = new(Guid.NewGuid().ToString());
        public string Block { get; set; }
    }