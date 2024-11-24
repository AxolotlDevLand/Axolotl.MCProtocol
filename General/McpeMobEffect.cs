#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeMobEffect : Packet
    {
        public int amplifier; // = null;
        public int duration; // = null;
        public int effectId; // = null;
        public byte eventId; // = null;
        public bool particles; // = null;

        public long runtimeEntityId; // = null;

        public McpeMobEffect()
            {
                Id = 0x1c;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                Write(eventId);
                WriteSignedVarInt(effectId);
                WriteSignedVarInt(amplifier);
                Write(particles);
                WriteSignedVarInt(duration);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                eventId = ReadByte();
                effectId = ReadSignedVarInt();
                amplifier = ReadSignedVarInt();
                particles = ReadBool();
                duration = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                eventId = default;
                effectId = default;
                amplifier = default;
                particles = default;
                duration = default;
            }
    }