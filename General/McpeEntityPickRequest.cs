#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeEntityPickRequest : Packet
    {
        public bool addUserData; // = null;

        public ulong runtimeEntityId; // = null;
        public byte selectedSlot; // = null;

        public McpeEntityPickRequest()
            {
                Id = 0x23;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(runtimeEntityId);
                Write(selectedSlot);
                Write(addUserData);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUlong();
                selectedSlot = ReadByte();
                addUserData = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                selectedSlot = default;
                addUserData = default;
            }
    }