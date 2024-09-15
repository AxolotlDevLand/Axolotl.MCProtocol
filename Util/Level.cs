using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axolotl.Util;

namespace Axolotl.Util
{
    public class Level
    {

        public static readonly BlockCoordinates Up = new BlockCoordinates(0, 1, 0);
        public static readonly BlockCoordinates Down = new BlockCoordinates(0, -1, 0);
        public static readonly BlockCoordinates South = new BlockCoordinates(0, 0, 1);
        public static readonly BlockCoordinates North = new BlockCoordinates(0, 0, -1);
        public static readonly BlockCoordinates East = new BlockCoordinates(1, 0, 0);
        public static readonly BlockCoordinates West = new BlockCoordinates(-1, 0, 0);
        private int _worldDayCycleTime = 24000;
        public PlayerLocation SpawnPoint { get; set; } = null;
        public int SaveInterval { get; set; } = 300;
        public int UnloadInterval { get; set; } = -1;

        public string fog { get; set; } = "";
        public int ViewDistance { get; set; }

        public int TickDistance { get; set; }

        public Random Random { get; private set; }
        public string LevelId { get; private set; }

        public string LevelName { get; private set; }
        public Dimension Dimension { get; set; } = Dimension.Overworld;

        public GameMode GameMode { get; private set; }
        public bool IsSurvival => GameMode == GameMode.Survival;
        public bool HaveDownfall { get; set; }
        public Difficulty Difficulty { get; set; }
        public bool AutoSmelt { get; set; } = false;
        public long WorldTime { get; set; }
        public long CurrentWorldCycleTime { get; private set; }
        public long TickTime { get; set; }
        public int SkylightSubtracted { get; set; }
        public long StartTimeInTicks { get; private set; }
        public bool EnableBlockTicking { get; set; } = false;
        public bool EnableChunkTicking { get; set; } = false;

        public bool AllowBuild { get; set; } = true;
        public bool AllowBreak { get; set; } = true;
    }
}
