#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePlayerInput : Packet
    {
        public bool jumping; // = null;

        public float motionX; // = null;
        public float motionZ; // = null;
        public bool sneaking; // = null;

        public McpePlayerInput()
            {
                Id = 0x39;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(motionX);
                Write(motionZ);
                Write(jumping);
                Write(sneaking);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                motionX = ReadFloat();
                motionZ = ReadFloat();
                jumping = ReadBool();
                sneaking = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                motionX = default;
                motionZ = default;
                jumping = default;
                sneaking = default;
            }
    }