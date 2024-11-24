#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSubChunkPacket : Packet
    {
        public bool cacheEnabled; // = null;
        public int dimension; // = null;
        public BlockCoordinates subchunkCoordinates; // = null;

        public McpeSubChunkPacket()
            {
                Id = 0xae;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(cacheEnabled);
                WriteVarInt(dimension);
                Write(subchunkCoordinates);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                cacheEnabled = ReadBool();
                dimension = ReadVarInt();
                subchunkCoordinates = ReadBlockCoordinates();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                cacheEnabled = default;
                dimension = default;
                subchunkCoordinates = default;
            }
    }