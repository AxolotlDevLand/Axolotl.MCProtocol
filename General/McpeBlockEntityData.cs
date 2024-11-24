#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeBlockEntityData : Packet
    {
        public BlockCoordinates coordinates; // = null;
        public Nbt namedtag; // = null;

        public McpeBlockEntityData()
            {
                Id = 0x38;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(coordinates);
                Write(namedtag);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                coordinates = ReadBlockCoordinates();
                namedtag = ReadNbt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                coordinates = default;
                namedtag = default;
            }
    }