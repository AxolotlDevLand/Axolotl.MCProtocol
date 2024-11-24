#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeShowStoreOffer : Packet
    {
        public string unknown0; // = null;
        public bool unknown1; // = null;

        public McpeShowStoreOffer()
            {
                Id = 0x5b;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(unknown0);
                Write(unknown1);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                unknown0 = ReadString();
                unknown1 = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                unknown0 = default;
                unknown1 = default;
            }
    }