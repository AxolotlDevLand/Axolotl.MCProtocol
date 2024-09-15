using System.Collections.Generic;

namespace Axolotl
{
    public class pixelList
    {
        public List<pixelsData> mapData = new List<pixelsData>();
    }
    public class pixelsData
    {
        public uint pixel;
        public short index;
    }
}