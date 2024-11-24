#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetScoreboardIdentity : Packet
    {
        public enum Operations
            {
                RegisterIdentity = 0,
                ClearIdentity = 1
            }

        public ScoreboardIdentityEntries entries; // = null;

        public McpeSetScoreboardIdentity()
            {
                Id = 0x70;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(entries);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                entries = ReadScoreboardIdentityEntries();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                entries = default;
            }
    }