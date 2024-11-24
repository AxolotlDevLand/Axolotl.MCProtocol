#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeLevelChunk : Packet
    {
        public int chunkX; // = null;
        public int chunkZ; // = null;

        public McpeLevelChunk()
            {
                Id = 0x3a;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(chunkX);
                WriteSignedVarInt(chunkZ);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                chunkX = ReadSignedVarInt();
                chunkZ = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                chunkX = default;
                chunkZ = default;
            }
    }