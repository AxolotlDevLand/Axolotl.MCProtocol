namespace Axolotl.Util;

[Flags]
public enum PlayerAbility : uint
    {
        Build = 1 << 0,
        Mine = 1 << 1,
        DoorsAndSwitches = 1 << 2,
        OpenContainers = 1 << 3,
        AttackPlayers = 1 << 4,
        AttackMobs = 1 << 5,
        OperatorCommands = 1 << 6,
        Teleport = 1 << 7,
        Invulnerable = 1 << 8,
        Flying = 1 << 9,
        MayFly = 1 << 10,
        InstantBuild = 1 << 11,
        Lightning = 1 << 12,
        FlySpeed = 1 << 13,
        WalkSpeed = 1 << 14,
        Muted = 1 << 15,
        WorldBuilder = 1 << 16,
        NoClip = 1 << 17,
        PrivilegedBuilder = 1 << 18,
        All = (1 << 19) - 1
    }