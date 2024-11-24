#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeLabTable : Packet
    {
        public int labTableX; // = null;
        public int labTableY; // = null;
        public int labTableZ; // = null;
        public byte reactionType; // = null;

        public byte uselessByte; // = null;

        public McpeLabTable()
            {
                Id = 0x6d;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(uselessByte);
                WriteVarInt(labTableX);
                WriteVarInt(labTableY);
                WriteVarInt(labTableZ);
                Write(reactionType);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                uselessByte = ReadByte();
                labTableX = ReadVarInt();
                labTableY = ReadVarInt();
                labTableZ = ReadVarInt();
                reactionType = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                uselessByte = default;
                labTableX = default;
                labTableY = default;
                labTableZ = default;
                reactionType = default;
            }
    }