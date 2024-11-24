#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeBlockEvent : Packet
    {
        public int case1; // = null;
        public int case2; // = null;

        public BlockCoordinates coordinates; // = null;

        public McpeBlockEvent()
            {
                Id = 0x1a;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(coordinates);
                WriteSignedVarInt(case1);
                WriteSignedVarInt(case2);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                coordinates = ReadBlockCoordinates();
                case1 = ReadSignedVarInt();
                case2 = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                coordinates = default;
                case1 = default;
                case2 = default;
            }
    }