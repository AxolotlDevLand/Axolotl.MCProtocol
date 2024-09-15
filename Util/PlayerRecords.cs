using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axolotl.Actor;
using Axolotl.Util;

namespace Axolotl.Util
{
    public class Records : List<BlockCoordinates>
    {
        public Records()
        {
        }

        public Records(IEnumerable<BlockCoordinates> coordinates) : base(coordinates)
        {
        }
    }

    public abstract class PlayerRecords : List<Player>
    {
        public PlayerRecords()
        {
        }

        public PlayerRecords(IEnumerable<Player> players) : base(players)
        {
        }
    }

    public class PlayerAddRecords : PlayerRecords
    {
        public PlayerAddRecords()
        {
        }


        public PlayerAddRecords(IEnumerable<Player> players) : base(players)
        {
        }
    }

    public class PlayerRemoveRecords : PlayerRecords
    {
        public PlayerRemoveRecords()
        {
        }


        public PlayerRemoveRecords(IEnumerable<Player> players) : base(players)
        {
        }
    }
}
