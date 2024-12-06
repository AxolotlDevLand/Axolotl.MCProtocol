namespace Axolotl;

public class EnchantmentLevel
    {
        public EnchantmentLevel(int minLevel, int maxLevel, byte level)
            {
                MinLevel = minLevel;
                MaxLevel = maxLevel;
                Level = level;
            }

        public int MinLevel { get; private set; }
        public int MaxLevel { get; private set; }
        public byte Level { get; private set; }
    }