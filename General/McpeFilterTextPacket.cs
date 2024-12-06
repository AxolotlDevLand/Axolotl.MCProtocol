#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeFilterTextPacket : Packet
    {
        public bool fromServer; // = null;

        public string text; // = null;

        public McpeFilterTextPacket()
            {
                Id = 0xa3;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(text);
                Write(fromServer);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                text = ReadString();
                fromServer = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                text = default;
                fromServer = default;
            }
    }