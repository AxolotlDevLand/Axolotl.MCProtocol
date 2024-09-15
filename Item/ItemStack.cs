using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.Items
{
    public class ItemStacks : List<Item>
    {
    }

    public class CreativeItemStacks : ItemStacks
    {

    }

    /// <summary>
    /// An item stack without unique identifiers
    /// </summary>
    public class GlobalItemStacks : List<Item>
    {
    }
}
