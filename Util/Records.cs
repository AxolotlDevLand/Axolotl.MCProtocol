namespace Axolotl.Util;

public class Records : List<BlockCoordinates>
    {
        public Records()
            {
            }

        public Records(IEnumerable<BlockCoordinates> coordinates) : base(coordinates)
            {
            }
    }