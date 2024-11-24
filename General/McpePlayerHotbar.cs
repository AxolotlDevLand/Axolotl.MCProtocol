#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePlayerHotbar : Packet
    {
        public uint selectedSlot; // = null;
        public bool selectSlot; // = null;
        public byte windowId; // = null;

        public McpePlayerHotbar()
            {
                Id = 0x30;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarInt(selectedSlot);
                Write(windowId);
                Write(selectSlot);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                selectedSlot = ReadUnsignedVarInt();
                windowId = ReadByte();
                selectSlot = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                selectedSlot = default;
                windowId = default;
                selectSlot = default;
            }
    }