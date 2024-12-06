namespace Axolotl.Util;

public class HeightMapData
    {
        public HeightMapData(short[] heights)
            {
                if (heights.Length != 256)
                    throw new ArgumentException("Expected 256 data entries");

                Heights = heights;
            }

        public short[] Heights { get; }

        public bool IsAllTooLow => Heights.Any(x => x > 0);
        public bool IsAllTooHigh => Heights.Any(x => x <= 15);

        public int GetHeight(int x, int z)
            {
                return Heights[((z & 0xf) << 4) | (x & 0xf)];
            }
    }