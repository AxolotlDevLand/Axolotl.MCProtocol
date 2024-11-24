#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeUpdateAbilities : Packet
    {
        public byte commandPermissions; // = null;

        public long entityUniqueId; // = null;
        public AbilityLayers layers; // = null;
        public byte playerPermissions; // = null;

        public McpeUpdateAbilities()
            {
                Id = 0xbb;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(entityUniqueId);
                Write(playerPermissions);
                Write(commandPermissions);
                Write(layers);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                entityUniqueId = ReadLong();
                playerPermissions = ReadByte();
                commandPermissions = ReadByte();
                layers = ReadAbilityLayers();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                entityUniqueId = default;
                playerPermissions = default;
                commandPermissions = default;
                layers = default;
            }
    }