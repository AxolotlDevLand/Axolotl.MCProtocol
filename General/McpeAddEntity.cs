#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeAddEntity : Packet
    {
        public EntityAttributes attributes; // = null;
        public float bodyYaw; // = null;

        public long entityIdSelf; // = null;
        public string entityType; // = null;
        public float headYaw; // = null;
        public EntityLinks links; // = null;
        public MetadataDictionary metadata; // = null;
        public float pitch; // = null;
        public long runtimeEntityId; // = null;
        public float speedX; // = null;
        public float speedY; // = null;
        public float speedZ; // = null;
        public PropertySyncData syncdata; // = null;
        public float x; // = null;
        public float y; // = null;
        public float yaw; // = null;
        public float z; // = null;

        public McpeAddEntity()
            {
                Id = 0x0d;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarLong(entityIdSelf);
                WriteUnsignedVarLong(runtimeEntityId);
                Write(entityType);
                Write(x);
                Write(y);
                Write(z);
                Write(speedX);
                Write(speedY);
                Write(speedZ);
                Write(pitch);
                Write(yaw);
                Write(headYaw);
                Write(bodyYaw);
                Write(attributes);
                Write(metadata);
                Write(syncdata);
                Write(links);

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
                entityType = ReadString();
                x = ReadFloat();
                y = ReadFloat();
                z = ReadFloat();
                speedX = ReadFloat();
                speedY = ReadFloat();
                speedZ = ReadFloat();
                pitch = ReadFloat();
                yaw = ReadFloat();
                headYaw = ReadFloat();
                bodyYaw = ReadFloat();
                attributes = ReadEntityAttributes();
                metadata = ReadMetadataDictionary();
                syncdata = ReadPropertySyncData();
                links = ReadEntityLinks();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                entityIdSelf = default;
                runtimeEntityId = default;
                entityType = default;
                x = default;
                y = default;
                z = default;
                speedX = default;
                speedY = default;
                speedZ = default;
                pitch = default;
                yaw = default;
                headYaw = default;
                bodyYaw = default;
                attributes = default;
                metadata = default;
                syncdata = default;
                links = default;
            }
    }