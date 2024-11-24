#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeHurtArmor : Packet
    {
        public long armorSlotFlags; // = null;

        public int cause; // = null;
        public int health; // = null;

        public McpeHurtArmor()
            {
                Id = 0x26;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteVarInt(cause);
                WriteSignedVarInt(health);
                WriteUnsignedVarLong(armorSlotFlags);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                cause = ReadVarInt();
                health = ReadSignedVarInt();
                armorSlotFlags = ReadUnsignedVarLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                cause = default;
                health = default;
                armorSlotFlags = default;
            }
    }