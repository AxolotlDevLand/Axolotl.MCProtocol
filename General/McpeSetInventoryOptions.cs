#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetInventoryOptions : Packet
    {
        public int craftinglayout; // = null;
        public bool filtering; // = null;
        public int inventorylayout; // = null;

        public int lefttab; // = null;
        public int righttab; // = null;

        public McpeSetInventoryOptions()
            {
                Id = 0x133;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(lefttab);
                WriteSignedVarInt(righttab);
                Write(filtering);
                WriteSignedVarInt(inventorylayout);
                WriteSignedVarInt(craftinglayout);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                lefttab = ReadSignedVarInt();
                righttab = ReadSignedVarInt();
                filtering = ReadBool();
                inventorylayout = ReadSignedVarInt();
                craftinglayout = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                lefttab = default;
                righttab = default;
                filtering = default;
                inventorylayout = default;
                craftinglayout = default;
            }
    }