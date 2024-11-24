#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeRespawn : Packet
    {
        public enum RespawnState
            {
                Search = 0,
                Ready = 1,
                ClientReady = 2
            }

        public long runtimeEntityId; // = null;
        public byte state; // = null;

        public float x; // = null;
        public float y; // = null;
        public float z; // = null;

        public McpeRespawn()
            {
                Id = 0x2d;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(x);
                Write(y);
                Write(z);
                Write(state);
                WriteUnsignedVarLong(runtimeEntityId);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                x = ReadFloat();
                y = ReadFloat();
                z = ReadFloat();
                state = ReadByte();
                runtimeEntityId = ReadUnsignedVarLong();

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
                state = default;
                runtimeEntityId = default;
            }
    }