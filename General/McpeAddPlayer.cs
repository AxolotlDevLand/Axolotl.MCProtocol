#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeAddPlayer : Packet
    {
        public byte commandPermissions; // = null;
        public string deviceId; // = null;
        public int deviceOs; // = null;
        public long entityIdSelf; // = null;
        public uint gameType; // = null;
        public float headYaw; // = null;
        public Item item; // = null;
        public AbilityLayers layers; // = null;
        public EntityLinks links; // = null;
        public MetadataDictionary metadata; // = null;
        public float pitch; // = null;
        public string platformChatId; // = null;
        public byte playerPermissions; // = null;
        public long runtimeEntityId; // = null;
        public float speedX; // = null;
        public float speedY; // = null;
        public float speedZ; // = null;
        public PropertySyncData syncdata; // = null;
        public string username; // = null;

        public UUID uuid; // = null;
        public float x; // = null;
        public float y; // = null;
        public float yaw; // = null;
        public float z; // = null;

        public McpeAddPlayer()
            {
                Id = 0x0c;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(uuid);
                Write(username);
                WriteUnsignedVarLong(runtimeEntityId);
                Write(platformChatId);
                Write(x);
                Write(y);
                Write(z);
                Write(speedX);
                Write(speedY);
                Write(speedZ);
                Write(pitch);
                Write(yaw);
                Write(headYaw);
                Write(item);
                WriteUnsignedVarInt(gameType);
                Write(metadata);
                Write(syncdata);
                WriteSignedVarLong(entityIdSelf);
                Write(playerPermissions);
                Write(commandPermissions);
                Write(layers);
                Write(links);
                Write(deviceId);
                Write(deviceOs);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                uuid = ReadUUID();
                username = ReadString();
                runtimeEntityId = ReadUnsignedVarLong();
                platformChatId = ReadString();
                x = ReadFloat();
                y = ReadFloat();
                z = ReadFloat();
                speedX = ReadFloat();
                speedY = ReadFloat();
                speedZ = ReadFloat();
                pitch = ReadFloat();
                yaw = ReadFloat();
                headYaw = ReadFloat();
                item = ReadItem();
                gameType = ReadUnsignedVarInt();
                metadata = ReadMetadataDictionary();
                syncdata = ReadPropertySyncData();
                entityIdSelf = ReadSignedVarLong();
                playerPermissions = ReadByte();
                commandPermissions = ReadByte();
                layers = ReadAbilityLayers();
                links = ReadEntityLinks();
                deviceId = ReadString();
                deviceOs = ReadInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                uuid = default;
                username = default;
                runtimeEntityId = default;
                platformChatId = default;
                x = default;
                y = default;
                z = default;
                speedX = default;
                speedY = default;
                speedZ = default;
                pitch = default;
                yaw = default;
                headYaw = default;
                item = default;
                gameType = default;
                metadata = default;
                syncdata = default;
                entityIdSelf = default;
                playerPermissions = default;
                commandPermissions = default;
                layers = default;
                links = default;
                deviceId = default;
                deviceOs = default;
            }
    }