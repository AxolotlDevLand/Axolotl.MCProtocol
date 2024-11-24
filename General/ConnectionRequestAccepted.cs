#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class ConnectionRequestAccepted : Packet
    {
        public long incomingTimestamp; // = null;
        public long serverTimestamp; // = null;

        public IPEndPoint systemAddress; // = null;
        public IPEndPoint[] systemAddresses; // = null;
        public short systemIndex; // = null;

        public ConnectionRequestAccepted()
            {
                Id = 0x10;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(systemAddress);
                WriteBe(systemIndex);
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

                systemAddress = ReadIPEndPoint();
                systemIndex = ReadShortBe();
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

                systemAddress = default;
                systemIndex = default;
                systemAddresses = default;
                incomingTimestamp = default;
                serverTimestamp = default;
            }
    }