#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeBlockPickRequest : Packet
    {
        public bool addUserData; // = null;
        public byte selectedSlot; // = null;

        public int x; // = null;
        public int y; // = null;
        public int z; // = null;

        public McpeBlockPickRequest()
            {
                Id = 0x22;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(x);
                WriteSignedVarInt(y);
                WriteSignedVarInt(z);
                Write(addUserData);
                Write(selectedSlot);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                x = ReadSignedVarInt();
                y = ReadSignedVarInt();
                z = ReadSignedVarInt();
                addUserData = ReadBool();
                selectedSlot = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                x = default;
                y = default;
                z = default;
                addUserData = default;
                selectedSlot = default;
            }
    }