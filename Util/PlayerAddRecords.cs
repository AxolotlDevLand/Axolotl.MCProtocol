namespace Axolotl.Util;

using Actor;

public class PlayerAddRecords : PlayerRecords
    {
        public PlayerAddRecords()
            {
            }


        public PlayerAddRecords(IEnumerable<Player> players) : base(players)
            {
            }
    }