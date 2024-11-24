#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeChangeDimension : Packet
    {
        public int dimension; // = null;
        private readonly byte fix = 0x00;
        public Vector3 position; // = null;
        public bool respawn; // = null;

        public McpeChangeDimension()
            {
                Id = 0x3d;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(dimension);
                Write(position);
                Write(respawn);
                Write(fix);
                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                dimension = ReadSignedVarInt();
                position = ReadVector3();
                respawn = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                dimension = default;
                position = default;
                respawn = default;
            }
    }