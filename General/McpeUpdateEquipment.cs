#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeUpdateEquipment : Packet
    {
        public long entityId; // = null;
        public Nbt namedtag; // = null;
        public byte unknown; // = null;

        public byte windowId; // = null;
        public byte windowType; // = null;

        public McpeUpdateEquipment()
            {
                Id = 0x51;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(windowId);
                Write(windowType);
                Write(unknown);
                WriteSignedVarLong(entityId);
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
                unknown = ReadByte();
                entityId = ReadSignedVarLong();
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
                unknown = default;
                entityId = default;
                namedtag = default;
            }
    }