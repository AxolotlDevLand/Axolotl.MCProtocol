#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class NewIncomingConnection : Packet
    {
        public IPEndPoint clientendpoint; // = null;
        public long incomingTimestamp; // = null;
        public long serverTimestamp; // = null;
        public IPEndPoint[] systemAddresses; // = null;

        public NewIncomingConnection()
            {
                Id = 0x13;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(clientendpoint);
                Write(systemAddresses);
                Write(incomingTimestamp);
                Write(serverTimestamp);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                clientendpoint = ReadIPEndPoint();
                systemAddresses = ReadIPEndPoints(20);
                incomingTimestamp = ReadLong();
                serverTimestamp = ReadLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                clientendpoint = default;
                systemAddresses = default;
                incomingTimestamp = default;
                serverTimestamp = default;
            }
    }