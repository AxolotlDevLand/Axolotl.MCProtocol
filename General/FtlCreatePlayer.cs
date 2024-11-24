#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class FtlCreatePlayer : Packet
    {
        public long clientId; // = null;
        public UUID clientuuid; // = null;
        public string serverAddress; // = null;
        public Skin skin; // = null;

        public string username; // = null;

        public FtlCreatePlayer()
            {
                Id = 0x01;
                IsMcpe = false;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(username);
                Write(clientuuid);
                Write(serverAddress);
                Write(clientId);
                Write(skin);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                username = ReadString();
                clientuuid = ReadUUID();
                serverAddress = ReadString();
                clientId = ReadLong();
                skin = ReadSkin();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                username = default;
                clientuuid = default;
                serverAddress = default;
                clientId = default;
                skin = default;
            }
    }