#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeDisconnect : Packet
    {
        public uint failReason; // = null;
        public string filteredMessage; // = null

        public bool hideDisconnectReason; // = null;
        public string message; // = null;

        public McpeDisconnect()
            {
                Id = 0x05;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarInt(0); //todo
                Write(hideDisconnectReason);
                Write(message);
                Write(filteredMessage);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                failReason = ReadUnsignedVarInt();
                hideDisconnectReason = ReadBool();
                message = ReadString();
                filteredMessage = ReadString();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                hideDisconnectReason = default;
                message = default;
                failReason = default(int);
            }
    }