#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeAddPainting : Packet
    {
        public BlockCoordinates coordinates; // = null;
        public int direction; // = null;

        public long entityIdSelf; // = null;
        public long runtimeEntityId; // = null;
        public string title; // = null;

        public McpeAddPainting()
            {
                Id = 0x16;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarLong(entityIdSelf);
                WriteUnsignedVarLong(runtimeEntityId);
                Write(coordinates);
                WriteSignedVarInt(direction);
                Write(title);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                entityIdSelf = ReadSignedVarLong();
                runtimeEntityId = ReadUnsignedVarLong();
                coordinates = ReadBlockCoordinates();
                direction = ReadSignedVarInt();
                title = ReadString();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                entityIdSelf = default;
                runtimeEntityId = default;
                coordinates = default;
                direction = default;
                title = default;
            }
    }