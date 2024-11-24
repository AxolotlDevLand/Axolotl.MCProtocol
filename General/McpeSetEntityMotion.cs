#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetEntityMotion : Packet
    {
        public long runtimeEntityId; // = null;
        public Vector3 velocity; // = null;

        public McpeSetEntityMotion()
            {
                Id = 0x28;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                Write(velocity);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                velocity = ReadVector3();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                velocity = default;
            }
    }