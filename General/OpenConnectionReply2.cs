#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class OpenConnectionReply2 : Packet
    {
        public readonly byte[] offlineMessageDataId =
            {
                0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78
            }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };

        public IPEndPoint clientEndpoint; // = null;
        public byte[] doSecurityAndHandshake; // = null;
        public short mtuSize; // = null;
        public long serverGuid; // = null;

        public OpenConnectionReply2()
            {
                Id = 0x08;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(offlineMessageDataId);
                Write(serverGuid);
                Write(clientEndpoint);
                WriteBe(mtuSize);
                Write(doSecurityAndHandshake);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                ReadBytes(offlineMessageDataId.Length);
                serverGuid = ReadLong();
                clientEndpoint = ReadIPEndPoint();
                mtuSize = ReadShortBe();
                doSecurityAndHandshake = ReadBytes(0, true);

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                serverGuid = default;
                clientEndpoint = default;
                mtuSize = default;
                doSecurityAndHandshake = default;
            }
    }