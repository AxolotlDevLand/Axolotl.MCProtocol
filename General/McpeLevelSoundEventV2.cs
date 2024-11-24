#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeLevelSoundEventV2 : Packet
    {
        public int blockId; // = null;
        public string entityType; // = null;
        public bool isBabyMob; // = null;
        public bool isGlobal; // = null;
        public Vector3 position; // = null;

        public byte soundId; // = null;

        public McpeLevelSoundEventV2()
            {
                Id = 0x78;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(soundId);
                Write(position);
                WriteSignedVarInt(blockId);
                Write(entityType);
                Write(isBabyMob);
                Write(isGlobal);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                soundId = ReadByte();
                position = ReadVector3();
                blockId = ReadSignedVarInt();
                entityType = ReadString();
                isBabyMob = ReadBool();
                isGlobal = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                soundId = default;
                position = default;
                blockId = default;
                entityType = default;
                isBabyMob = default;
                isGlobal = default;
            }
    }