namespace Axolotl.MCProtocol.Packet;

public enum ActionPermissions
    {
        BuildAndMine = 0x1,
        DoorsAndSwitches = 0x2,
        OpenContainers = 0x4,
        AttackPlayers = 0x8,
        AttackMobs = 0x10,
        Operator = 0x20,
        Teleport = 0x80,
        Default = BuildAndMine | DoorsAndSwitches | OpenContainers | AttackPlayers | AttackMobs,
        All = BuildAndMine | DoorsAndSwitches | OpenContainers | AttackPlayers | AttackMobs | Operator | Teleport
    }