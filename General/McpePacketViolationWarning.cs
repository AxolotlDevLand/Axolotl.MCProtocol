#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePacketViolationWarning : Packet
    {
        public int packetId; // = null;
        public string reason; // = null;
        public int severity; // = null;

        public int violationType; // = null;

        public McpePacketViolationWarning()
            {
                Id = 0x9c;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(violationType);
                WriteSignedVarInt(severity);
                WriteSignedVarInt(packetId);
                Write(reason);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                violationType = ReadSignedVarInt();
                severity = ReadSignedVarInt();
                packetId = ReadSignedVarInt();
                reason = ReadString();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                violationType = default;
                severity = default;
                packetId = default;
                reason = default;
            }
    }