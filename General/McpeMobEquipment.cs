#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeMobEquipment : Packet
    {
        public Item item; // = null;

        public long runtimeEntityId; // = null;
        public byte selectedSlot; // = null;
        public byte slot; // = null;
        public byte windowsId; // = null;

        public McpeMobEquipment()
            {
                Id = 0x1f;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                Write(item);
                Write(slot);
                Write(selectedSlot);
                Write(windowsId);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                item = ReadItem();
                slot = ReadByte();
                selectedSlot = ReadByte();
                windowsId = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                item = default;
                slot = default;
                selectedSlot = default;
                windowsId = default;
            }
    }