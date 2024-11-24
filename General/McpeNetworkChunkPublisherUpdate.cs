#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeNetworkChunkPublisherUpdate : Packet
    {
        public BlockCoordinates coordinates; // = null;
        public uint radius; // = null;
        public int savedChunks; // = null;

        public McpeNetworkChunkPublisherUpdate()
            {
                Id = 0x79;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(coordinates);
                WriteUnsignedVarInt(radius);
                Write(savedChunks);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                coordinates = ReadBlockCoordinates();
                radius = ReadUnsignedVarInt();
                savedChunks = ReadInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                coordinates = default;
                radius = default;
                savedChunks = default;
            }
    }