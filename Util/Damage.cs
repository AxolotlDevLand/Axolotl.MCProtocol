using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.Util
{
    public enum DamageCause
    {
        [Description("{0} went MIA")] Unknown,

        [Description("{0} was pricked  to death")]
        Contact,
        [Description("{0} was slain by {1}")] EntityAttack,
        [Description("{0} was shot by {1}")] Projectile,

        [Description("{0} suffocated in a wall")]
        Suffocation,

        [Description("{0} hit the ground too hard")]
        Fall,
        [Description("{0} went up in flames")] Fire,
        [Description("{0} burned to death")] FireTick,

        [Description("{0} tried to swim in lava")]
        Lava,
        [Description("{0} drowned")] Drowning,
        [Description("{0} blew up")] BlockExplosion,
        [Description("{0} blew up")] EntityExplosion,

        [Description("{0} fell out of the world")]
        Void,
        [Description("{0} died")] Suicide,

        [Description("{0} was killed by magic")]
        Magic,
        [Description("{0} starved to death")] Starving,

        [Description("{0} died a customized death")]
        Custom
    }

    public class HealthManager
    {
        public int MaxHealth { get; set; } = 200;
        public int Health { get; set; }
        public float Absorption { get; set; }
        public short MaxAir { get; set; } = 400;
        public short Air { get; set; }
        public bool IsDead { get; set; }
        public int FireTick { get; set; }
        public int SuffocationTicks { get; set; }
        public int LavaTicks { get; set; }
        public int CooldownTick { get; set; }
        public bool IsOnFire { get; set; }
        public bool IsInvulnerable { get; set; }
        public DamageCause LastDamageCause { get; set; }
    }

}
