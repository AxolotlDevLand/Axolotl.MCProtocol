#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeAdventureSettings : Packet
    {
        public uint actionPermissions; // = null;
        public uint commandPermission; // = null;
        public uint customStoredPermissions; // = null;
        public long entityUniqueId; // = null;

        public uint flags; // = null;
        public uint permissionLevel; // = null;

        public McpeAdventureSettings()
            {
                Id = 0x37;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarInt(flags);
                WriteUnsignedVarInt(commandPermission);
                WriteUnsignedVarInt(actionPermissions);
                WriteUnsignedVarInt(permissionLevel);
                WriteUnsignedVarInt(customStoredPermissions);
                Write(entityUniqueId);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                flags = ReadUnsignedVarInt();
                commandPermission = ReadUnsignedVarInt();
                actionPermissions = ReadUnsignedVarInt();
                permissionLevel = ReadUnsignedVarInt();
                customStoredPermissions = ReadUnsignedVarInt();
                entityUniqueId = ReadLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                flags = default;
                commandPermission = default;
                actionPermissions = default;
                permissionLevel = default;
                customStoredPermissions = default;
                entityUniqueId = default;
            }
    }