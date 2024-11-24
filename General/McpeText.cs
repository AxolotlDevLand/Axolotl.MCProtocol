#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeText : Packet
    {
        public enum ChatTypes
            {
                Raw = 0,
                Chat = 1,
                Translation = 2,
                Popup = 3,
                Jukeboxpopup = 4,
                Tip = 5,
                System = 6,
                Whisper = 7,
                Announcement = 8,
                Json = 9,
                Jsonwhisper = 10,
                Jsonannouncement = 11
            }

        public byte type; // = null;

        public McpeText()
            {
                Id = 0x09;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(type);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                type = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                type = default;
            }
    }