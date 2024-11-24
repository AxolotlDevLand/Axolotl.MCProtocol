#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePlayerAction : Packet
    {

        public long runtimeEntityId; // = null;
        public int actionId; // = null;
        public BlockCoordinates coordinates; // = null;
        public BlockCoordinates resultCoordinates; // = null;
        public int face; // = null;

        public McpePlayerAction()
            {
                Id = 0x24;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                WriteSignedVarInt(actionId);
                Write(coordinates);
                Write(resultCoordinates);
                WriteSignedVarInt(face);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                actionId = ReadSignedVarInt();
                coordinates = ReadBlockCoordinates();
                resultCoordinates = ReadBlockCoordinates();
                face = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId=default(long);
                actionId=default(int);
                coordinates=default(BlockCoordinates);
                resultCoordinates=default(BlockCoordinates);
                face=default(int);
            }

    }