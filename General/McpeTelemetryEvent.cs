#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeTelemetryEvent : Packet
    {
        public byte[] auxData; // = null;
        public int eventData; // = null;
        public byte eventType; // = null;

        public long runtimeEntityId; // = null;

        public McpeTelemetryEvent()
            {
                Id = 0x41;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                WriteSignedVarInt(eventData);
                Write(eventType);
                Write(auxData);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                eventData = ReadSignedVarInt();
                eventType = ReadByte();
                auxData = ReadBytes(0, true);

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                eventData = default;
                eventType = default;
                auxData = default;
            }
    }