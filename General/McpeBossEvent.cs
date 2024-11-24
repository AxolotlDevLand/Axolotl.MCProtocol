#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeBossEvent : Packet
    {
        public enum Type
            {
                AddBoss = 0,
                AddPlayer = 1,
                RemoveBoss = 2,
                RemovePlayer = 3,
                UpdateProgress = 4,
                UpdateName = 5,
                UpdateOptions = 6,
                UpdateStyle = 7,
                Query = 8
            }

        public long bossEntityId; // = null;
        public uint eventType; // = null;

        public McpeBossEvent()
            {
                Id = 0x4a;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarLong(bossEntityId);
                WriteUnsignedVarInt(eventType);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                bossEntityId = ReadSignedVarLong();
                eventType = ReadUnsignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                bossEntityId = default;
                eventType = default;
            }
    }