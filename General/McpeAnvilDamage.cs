#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeAnvilDamage : Packet
    {
        public BlockCoordinates coordinates; // = null;

        public byte damageamount; // = null;

        public McpeAnvilDamage()
            {
                Id = 0x8d;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(damageamount);
                Write(coordinates);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                damageamount = ReadByte();
                coordinates = ReadBlockCoordinates();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                damageamount = default;
                coordinates = default;
            }
    }