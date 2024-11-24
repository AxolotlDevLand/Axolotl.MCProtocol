#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeNetworkStackLatency : Packet
    {
        public ulong timestamp; // = null;
        public byte unknownFlag; // = null;

        public McpeNetworkStackLatency()
            {
                Id = 0x73;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(timestamp);
                Write(unknownFlag);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                timestamp = ReadUlong();
                unknownFlag = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                timestamp = default;
                unknownFlag = default;
            }
    }