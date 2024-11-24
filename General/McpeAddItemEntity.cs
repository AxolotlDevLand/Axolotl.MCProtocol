#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeAddItemEntity : Packet
    {
        public long entityIdSelf; // = null;
        public bool isFromFishing; // = null;
        public Item item; // = null;
        public MetadataDictionary metadata; // = null;
        public long runtimeEntityId; // = null;
        public float speedX; // = null;
        public float speedY; // = null;
        public float speedZ; // = null;
        public float x; // = null;
        public float y; // = null;
        public float z; // = null;

        public McpeAddItemEntity()
            {
                Id = 0x0f;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarLong(entityIdSelf);
                WriteUnsignedVarLong(runtimeEntityId);
                Write(item);
                Write(x);
                Write(y);
                Write(z);
                Write(speedX);
                Write(speedY);
                Write(speedZ);
                Write(metadata);
                Write(isFromFishing);

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
                item = ReadItem();
                x = ReadFloat();
                y = ReadFloat();
                z = ReadFloat();
                speedX = ReadFloat();
                speedY = ReadFloat();
                speedZ = ReadFloat();
                metadata = ReadMetadataDictionary();
                isFromFishing = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                entityIdSelf = default;
                runtimeEntityId = default;
                item = default;
                x = default;
                y = default;
                z = default;
                speedX = default;
                speedY = default;
                speedZ = default;
                metadata = default;
                isFromFishing = default;
            }
    }