#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetSpawnPosition : Packet
    {
        public BlockCoordinates coordinates; // = null;
        public int dimension; // = null;

        public int spawnType; // = null;
        public BlockCoordinates unknownCoordinates; // = null;

        public McpeSetSpawnPosition()
            {
                Id = 0x2b;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(spawnType);
                Write(coordinates);
                WriteSignedVarInt(dimension);
                Write(unknownCoordinates);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                spawnType = ReadSignedVarInt();
                coordinates = ReadBlockCoordinates();
                dimension = ReadSignedVarInt();
                unknownCoordinates = ReadBlockCoordinates();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                spawnType = default;
                coordinates = default;
                dimension = default;
                unknownCoordinates = default;
            }
    }