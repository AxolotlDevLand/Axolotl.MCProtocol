#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePhotoTransfer : Packet
    {
        public string fileName; // = null;
        public string imageData; // = null;
        public string unknown2; // = null;

        public McpePhotoTransfer()
            {
                Id = 0x63;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(fileName);
                Write(imageData);
                Write(unknown2);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                fileName = ReadString();
                imageData = ReadString();
                unknown2 = ReadString();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                fileName = default;
                imageData = default;
                unknown2 = default;
            }
    }