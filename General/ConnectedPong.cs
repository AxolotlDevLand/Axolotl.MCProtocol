#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class ConnectedPong : Packet
    {
        public long sendpingtime; // = null;
        public long sendpongtime; // = null;

        public ConnectedPong()
            {
                Id = 0x03;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(sendpingtime);
                Write(sendpongtime);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                sendpingtime = ReadLong();
                sendpongtime = ReadLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                sendpingtime = default;
                sendpongtime = default;
            }
    }