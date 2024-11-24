#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetEntityLink : Packet
    {
        public enum LinkActions
            {
                Remove = 0,
                Ride = 1,
                Passenger = 2
            }

        public byte linkType; // = null;

        public long riddenId; // = null;
        public long riderId; // = null;
        public byte unknown; // = null;

        public McpeSetEntityLink()
            {
                Id = 0x29;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarLong(riddenId);
                WriteSignedVarLong(riderId);
                Write(linkType);
                Write(unknown);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                riddenId = ReadSignedVarLong();
                riderId = ReadSignedVarLong();
                linkType = ReadByte();
                unknown = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                riddenId = default;
                riderId = default;
                linkType = default;
                unknown = default;
            }
    }