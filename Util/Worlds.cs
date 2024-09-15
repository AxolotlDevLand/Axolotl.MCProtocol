using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.Util
{
    public enum Dimension
    {
        Overworld = 0,
        Nether = 1,
        TheEnd = 2
    }
    public enum GameMode
    {
        /// <summary>
        ///     Players fight against the enviornment, mobs, and players
        ///     with limited resources.
        /// </summary>
        Survival = 0,
        S = 0,

        /// <summary>
        ///     Players are given unlimited resources, flying, and
        ///     invulnerability.
        /// </summary>
        Creative = 1,
        C = 1,

        /// <summary>
        ///     Similar to survival, with the exception that players may
        ///     not place or remove blocks.
        /// </summary>
        Adventure = 2,

        /// <summary>
        ///     Similar to creative, with the exception that players may
        ///     not place or remove blocks.
        /// </summary>
        Spectator = 3
    }
    public enum Difficulty
    {
        Peaceful,
        Easy,
        Normal,
        Hard,
        Hardcore
    }
}
