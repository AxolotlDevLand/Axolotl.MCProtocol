#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class ConnectionRequest : Packet
    {
        public long clientGuid; // = null;
        public byte doSecurity; // = null;
        public long timestamp; // = null;

        public ConnectionRequest()
            {
                Id = 0x09;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(clientGuid);
                Write(timestamp);
                Write(doSecurity);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                clientGuid = ReadLong();
                timestamp = ReadLong();
                doSecurity = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                clientGuid = default;
                timestamp = default;
                doSecurity = default;
            }
    }