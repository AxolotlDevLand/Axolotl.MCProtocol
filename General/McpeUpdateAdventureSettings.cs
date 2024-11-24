#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeUpdateAdventureSettings : Packet
    {
        public bool autoJump; // = null;
        public bool immutableWorld; // = null;
        public bool noMvp; // = null;

        public bool noPvm; // = null;
        public bool showNametags; // = null;

        public McpeUpdateAdventureSettings()
            {
                Id = 0xbc;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(noPvm);
                Write(noMvp);
                Write(immutableWorld);
                Write(showNametags);
                Write(autoJump);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                noPvm = ReadBool();
                noMvp = ReadBool();
                immutableWorld = ReadBool();
                showNametags = ReadBool();
                autoJump = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                noPvm = default;
                noMvp = default;
                immutableWorld = default;
                showNametags = default;
                autoJump = default;
            }
    }