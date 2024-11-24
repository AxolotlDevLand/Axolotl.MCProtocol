#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeLevelEvent : Packet
    {
        public int data; // = null;

        public int eventId; // = null;
        public Vector3 position; // = null;

        public McpeLevelEvent()
            {
                Id = 0x19;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(eventId);
                Write(position);
                WriteSignedVarInt(data);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                eventId = ReadSignedVarInt();
                position = ReadVector3();
                data = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                eventId = default;
                position = default;
                data = default;
            }
    }