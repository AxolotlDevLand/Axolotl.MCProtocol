#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSimpleEvent : Packet
    {
        public ushort eventType; // = null;

        public McpeSimpleEvent()
            {
                Id = 0x40;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(eventType);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                eventType = ReadUshort();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                eventType = default;
            }
    }