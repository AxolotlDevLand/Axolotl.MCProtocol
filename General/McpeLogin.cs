#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeLogin : Packet
    {
        public byte[] payload; // = null;

        public int protocolVersion; // = null;

        public McpeLogin()
            {
                Id = 0x01;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteBe(protocolVersion);
                WriteByteArray(payload);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                protocolVersion = ReadIntBe();
                payload = ReadByteArray();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                protocolVersion = default;
                payload = default;
            }
    }