using System.Collections.Generic;

namespace Axolotl.Util
{
    public class fogStack
    {
        public List<string> fogList = new List<string>();

        public fogStack(params string[] efects)
        {
            fogList.AddRange(efects);
        }
    }
}