namespace Axolotl.Actor;

using System.Numerics;
using Util;

public class Mob
    {
        public Level Level { get; set; }

        public string EntityTypeId { get; protected set; }
        public long EntityId { get; set; }
        public bool IsSpawned { get; set; }
        public bool CanDespawn { get; set; } = true;

        public DateTime LastUpdatedTime { get; set; }
        public PlayerLocation KnownPosition { get; set; }
        public Vector3 Velocity { get; set; }
        public float PositionOffset { get; set; }
        public bool IsOnGround { get; set; } = true;

        public PlayerLocation LastSentPosition { get; set; }

        public HealthManager HealthManager { get; set; }
        public string NameTag { get; set; }

        public bool IsPanicking { get; set; }

        public bool NoAi { get; set; }
        public bool HideNameTag { get; set; } = true;
        public bool Silent { get; set; }
        public bool IsInWater { get; set; } = false;
        public bool IsOutOfWater => !IsInWater;
        public int PotionColor { get; set; }
        public int Variant { get; set; }
        public long Age { get; set; }
        public double Scale { get; set; } = 1.0;
        public virtual double Height { get; set; } = 1;
        public virtual double Width { get; set; } = 1;
        public virtual double Length { get; set; } = 1;
        public double Drag { get; set; } = 0.02;
        public double Gravity { get; set; } = 0.08;
        public int AttackDamage { get; set; } = 2;
        public int Data { get; set; }

        public long PortalDetected { get; set; }

        public Vector3 RiderSeatPosition { get; set; }
        public bool RiderRotationLocked { get; set; }
        public double RiderMaxRotation { get; set; }
        public double RiderMinRotation { get; set; }
    }