#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeInventoryContent : Packet
    {
        public ItemStacks input; // = null;

        public uint inventoryId; // = null;

        public McpeInventoryContent()
            {
                Id = 0x31;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarInt(inventoryId);
                Write(input);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                inventoryId = ReadUnsignedVarInt();
                input = ReadItemStacks();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                inventoryId = default;
                input = default;
            }
    }