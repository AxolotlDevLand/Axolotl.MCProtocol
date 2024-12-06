namespace Axolotl.Util;

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