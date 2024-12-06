namespace Axolotl.Util;

using Actor;

public class PlayerRemoveRecords : PlayerRecords
    {
        public PlayerRemoveRecords()
            {
            }


        public PlayerRemoveRecords(IEnumerable<Player> players) : base(players)
            {
            }
    }