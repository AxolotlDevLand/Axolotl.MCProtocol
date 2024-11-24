#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class UnconnectedPong : Packet
    {
        public readonly byte[] offlineMessageDataId =
            {
                0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78
            }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };

        public long pingId; // = null;
        public long serverId; // = null;
        public string serverName; // = null;

        public UnconnectedPong()
            {
                Id = 0x1c;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(pingId);
                Write(serverId);
                Write(offlineMessageDataId);
                WriteFixedString(serverName);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                pingId = ReadLong();
                serverId = ReadLong();
                ReadBytes(offlineMessageDataId.Length);
                serverName = ReadFixedString();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                pingId = default;
                serverId = default;
                serverName = default;
            }
    }