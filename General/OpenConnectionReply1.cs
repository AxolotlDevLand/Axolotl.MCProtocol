#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class OpenConnectionReply1 : Packet
    {
        public readonly byte[] offlineMessageDataId =
            {
                0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78
            }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };

        public short mtuSize; // = null;
        public long serverGuid; // = null;
        public byte serverHasSecurity; // = null;
        public int Cookie;
        public OpenConnectionReply1()
            {
                Id = 0x06;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(offlineMessageDataId);
                Write(serverGuid);
                Write(serverHasSecurity);
                if (serverHasSecurity == 0x01)
                    {
                        Write(Cookie);
                    }
                WriteBe(mtuSize);

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
                serverHasSecurity = ReadByte();
                if (serverHasSecurity == 0x01)
                    {
                       Cookie = ReadInt();
                    }
                mtuSize = ReadShortBe();
                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                serverGuid = default;
                serverHasSecurity = default;
                mtuSize = default;
                Cookie = default;
            }
    }