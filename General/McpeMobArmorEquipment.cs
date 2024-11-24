#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeMobArmorEquipment : Packet
    {
        public Item boots; // = null;
        public Item chestplate; // = null;
        public Item helmet; // = null;
        public Item leggings; // = null;

        public long runtimeEntityId; // = null;

        public McpeMobArmorEquipment()
            {
                Id = 0x20;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                Write(helmet);
                Write(chestplate);
                Write(leggings);
                Write(boots);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                helmet = ReadItem();
                chestplate = ReadItem();
                leggings = ReadItem();
                boots = ReadItem();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                helmet = default;
                chestplate = default;
                leggings = default;
                boots = default;
            }
    }