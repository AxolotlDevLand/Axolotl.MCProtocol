#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class OpenConnectionRequest2 : Packet
    {
        public readonly byte[] offlineMessageDataId =
            {
                0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78
            }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };

        public long clientGuid; // = null;
        public short mtuSize; // = null;
        public IPEndPoint remoteBindingAddress; // = null;
        public int Cookie;
        public byte Client_supports_security;
        public OpenConnectionRequest2()
            {
                Id = 0x07;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(offlineMessageDataId);
                
                if (Client_supports_security == 0x01)
                    {
                        Write(Cookie);
                        Write(Client_supports_security);
                    }
                Write(remoteBindingAddress);
                WriteBe(mtuSize);
                Write(clientGuid);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                ReadBytes(offlineMessageDataId.Length);
               
                if (Client_supports_security == 0x01)
                    {
                        Cookie = ReadInt();
                        ReadByte();
                    }
                remoteBindingAddress = ReadIPEndPoint();
                mtuSize = ReadShortBe();
                clientGuid = ReadLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                remoteBindingAddress = default;
                mtuSize = default;
                clientGuid = default;
            }
    }