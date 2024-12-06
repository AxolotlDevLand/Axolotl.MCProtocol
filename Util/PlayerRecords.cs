namespace Axolotl.Util;

using Actor;

public abstract class PlayerRecords : List<Player>
    {
        public PlayerRecords()
            {
            }

        public PlayerRecords(IEnumerable<Player> players) : base(players)
            {
            }
    }