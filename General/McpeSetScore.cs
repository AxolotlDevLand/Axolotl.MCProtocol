#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetScore : Packet
    {
        public enum ChangeTypes
            {
                Player = 1,
                Entity = 2,
                FakePlayer = 3
            }

        public enum Types
            {
                Change = 0,
                Remove = 1
            }

        public ScoreEntries entries; // = null;

        public McpeSetScore()
            {
                Id = 0x6c;
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

                entries = ReadScoreEntries();

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