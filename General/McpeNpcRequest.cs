#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeNpcRequest : Packet
    {
        public long runtimeEntityId; // = null;
        public byte unknown0; // = null;
        public string unknown1; // = null;
        public byte unknown2; // = null;

        public McpeNpcRequest()
            {
                Id = 0x62;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                Write(unknown0);
                Write(unknown1);
                Write(unknown2);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                unknown0 = ReadByte();
                unknown1 = ReadString();
                unknown2 = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                unknown0 = default;
                unknown1 = default;
                unknown2 = default;
            }
    }