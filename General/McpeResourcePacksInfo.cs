#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeResourcePacksInfo : Packet
    {
        public uint cndUrls; // = null;
        public bool hasAddons; // = null;
        public bool hasScripts; // = null;

        public bool mustAccept; // = null;
        public TexturePackInfos texturepacks; // = null;

        public McpeResourcePacksInfo()
            {
                Id = 0x06;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(mustAccept);
                Write(false); //addons that we don't and won't have
                Write(hasScripts);
                Write(texturepacks);
                WriteUnsignedVarInt(cndUrls);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                mustAccept = ReadBool();
                hasAddons = ReadBool();
                hasScripts = ReadBool();
                texturepacks = ReadTexturePackInfos();
                cndUrls = ReadUnsignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                mustAccept = default;
                hasAddons = default;
                hasScripts = default;
                texturepacks = default;
                cndUrls = default;
            }
    }