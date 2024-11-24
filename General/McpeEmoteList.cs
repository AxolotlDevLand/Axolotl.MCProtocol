#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeEmoteList : Packet
    {
        public EmoteIds emoteids; // = null;

        public long runtimeentityid; // = null;

        public McpeEmoteList()
            {
                Id = 0x98;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeentityid);
                Write(emoteids);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeentityid = ReadUnsignedVarLong();
                emoteids = ReadEmoteId();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeentityid = default;
                emoteids = default;
            }
    }