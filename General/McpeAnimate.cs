#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeAnimate : Packet
    {
        public int actionId; // = null;
        public long runtimeEntityId; // = null;

        public McpeAnimate()
            {
                Id = 0x2c;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(actionId);
                WriteUnsignedVarLong(runtimeEntityId);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                actionId = ReadSignedVarInt();
                runtimeEntityId = ReadUnsignedVarLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                actionId = default;
                runtimeEntityId = default;
            }
    }