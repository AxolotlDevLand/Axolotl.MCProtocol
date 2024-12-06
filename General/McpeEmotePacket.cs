#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeEmotePacket : Packet
    {
        public string emoteid; // = null;
        public byte flags; // = null;
        public string platformid; // = null;

        public long runtimeentityid; // = null;
        public string xuid; // = null;

        public McpeEmotePacket()
            {
                Id = 0x8a;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeentityid);
                Write(xuid);
                Write(platformid);
                Write(emoteid);
                Write(flags);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeentityid = ReadUnsignedVarLong();
                xuid = ReadString();
                platformid = ReadString();
                emoteid = ReadString();
                flags = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeentityid = default;
                xuid = default;
                platformid = default;
                emoteid = default;
                flags = default;
            }
    }