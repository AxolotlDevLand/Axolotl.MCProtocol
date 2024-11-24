#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeTakeItemEntity : Packet
    {
        public long runtimeEntityId; // = null;
        public long target; // = null;

        public McpeTakeItemEntity()
            {
                Id = 0x11;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                WriteUnsignedVarLong(target);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                target = ReadUnsignedVarLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                target = default;
            }
    }