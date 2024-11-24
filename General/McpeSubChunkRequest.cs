#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSubChunkRequestPacket : Packet
    {
        public BlockCoordinates basePosition; // = null;

        public int dimension; // = null;
        public SubChunkPositionOffset[] offsets; // = null;

        public McpeSubChunkRequestPacket()
            {
                Id = 0xaf;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteVarInt(dimension);
                Write(basePosition);
                Write(offsets);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                dimension = ReadVarInt();
                basePosition = ReadBlockCoordinates();
                offsets = ReadSubChunkPositionOffsets();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                dimension = default;
                basePosition = default;
                offsets = default;
            }
    }