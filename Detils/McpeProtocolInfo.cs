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