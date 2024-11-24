#pragma warning disable
using Axolotl;
using Axolotl.MCProtocol;
using Axolotl.MCProtocol;
using Axolotl.MCProtocol.Packet;

namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;

public class McpeProtocolInfo
{
    public const int ProtocolVersion = 729;
    public const string GameVersion = "1.21.31";
}

public enum AdventureFlags
{
    Mayfly = 0x40,
    Noclip = 0x80,
    Worldbuilder = 0x100,
    Flying = 0x200,
    Muted = 0x400
}

public enum CommandPermission
{
    Normal = 0,
    Operator = 1,
    Host = 2,
    Automation = 3,
    Admin = 4
}

public enum PermissionLevel
{
    Visitor = 0,
    Member = 1,
    Operator = 2,
    Custom = 3
}

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