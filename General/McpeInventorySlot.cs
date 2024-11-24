#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeInventorySlot : Packet
    {
        public uint inventoryId; // = null;
        public Item item; // = null;
        public uint slot; // = null;

        public McpeInventorySlot()
            {
                Id = 0x32;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarInt(inventoryId);
                WriteUnsignedVarInt(slot);
                Write(item);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                inventoryId = ReadUnsignedVarInt();
                slot = ReadUnsignedVarInt();
                item = ReadItem();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                inventoryId = default;
                slot = default;
                item = default;
            }
    }