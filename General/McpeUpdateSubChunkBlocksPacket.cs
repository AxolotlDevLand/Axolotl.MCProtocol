#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeUpdateSubChunkBlocksPacket : Packet
    {
        public UpdateSubChunkBlocksPacketEntry[] layerOneUpdates; // = null;
        public UpdateSubChunkBlocksPacketEntry[] layerZeroUpdates; // = null;

        public BlockCoordinates subchunkCoordinates; // = null;

        public McpeUpdateSubChunkBlocksPacket()
            {
                Id = 0xac;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(subchunkCoordinates);
                Write(layerZeroUpdates);
                Write(layerOneUpdates);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                subchunkCoordinates = ReadBlockCoordinates();
                layerZeroUpdates = ReadUpdateSubChunkBlocksPacketEntrys();
                layerOneUpdates = ReadUpdateSubChunkBlocksPacketEntrys();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                subchunkCoordinates = default;
                layerZeroUpdates = default;
                layerOneUpdates = default;
            }
    }