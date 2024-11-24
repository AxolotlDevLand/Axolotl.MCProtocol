#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetTitle : Packet
    {
        public int fadeInTime; // = null;
        public int fadeOutTime; // = null;
        public string platformOnlineId; // = null;
        public int stayTime; // = null;
        public string text; // = null;

        public int type; // = null;
        public string xuid; // = null;

        public McpeSetTitle()
            {
                Id = 0x58;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(type);
                Write(text);
                WriteSignedVarInt(fadeInTime);
                WriteSignedVarInt(stayTime);
                WriteSignedVarInt(fadeOutTime);
                Write(xuid);
                Write(platformOnlineId);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                type = ReadSignedVarInt();
                text = ReadString();
                fadeInTime = ReadSignedVarInt();
                stayTime = ReadSignedVarInt();
                fadeOutTime = ReadSignedVarInt();
                xuid = ReadString();
                platformOnlineId = ReadString();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                type = default;
                text = default;
                fadeInTime = default;
                stayTime = default;
                fadeOutTime = default;
                xuid = default;
                platformOnlineId = default;
            }
    }