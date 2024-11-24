#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeUpdateTrade : Packet
    {
        public string displayName; // = null;
        public bool isWilling; // = null;
        public Nbt namedtag; // = null;
        public long playerEntityId; // = null;
        public long traderEntityId; // = null;
        public int unknown0; // = null;
        public int unknown1; // = null;
        public int unknown2; // = null;

        public byte windowId; // = null;
        public byte windowType; // = null;

        public McpeUpdateTrade()
            {
                Id = 0x50;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(windowId);
                Write(windowType);
                WriteVarInt(unknown0);
                WriteVarInt(unknown1);
                WriteVarInt(unknown2);
                Write(isWilling);
                WriteSignedVarLong(traderEntityId);
                WriteSignedVarLong(playerEntityId);
                Write(displayName);
                Write(namedtag);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                windowId = ReadByte();
                windowType = ReadByte();
                unknown0 = ReadVarInt();
                unknown1 = ReadVarInt();
                unknown2 = ReadVarInt();
                isWilling = ReadBool();
                traderEntityId = ReadSignedVarLong();
                playerEntityId = ReadSignedVarLong();
                displayName = ReadString();
                namedtag = ReadNbt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                windowId = default;
                windowType = default;
                unknown0 = default;
                unknown1 = default;
                unknown2 = default;
                isWilling = default;
                traderEntityId = default;
                playerEntityId = default;
                displayName = default;
                namedtag = default;
            }
    }