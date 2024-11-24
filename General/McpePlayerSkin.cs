#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePlayerSkin : Packet
    {
        public bool isVerified; // = null;
        public string oldSkinName; // = null;
        public Skin skin; // = null;
        public string skinName; // = null;

        public UUID uuid; // = null;

        public McpePlayerSkin()
            {
                Id = 0x5d;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(uuid);
                Write(skin);
                Write(skinName);
                Write(oldSkinName);
                Write(isVerified);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                uuid = ReadUUID();
                skin = ReadSkin();
                skinName = ReadString();
                oldSkinName = ReadString();
                isVerified = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                uuid = default;
                skin = default;
                skinName = default;
                oldSkinName = default;
                isVerified = default;
            }
    }