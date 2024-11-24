#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePermissionRequest : Packet
    {
        public short flagss; // = null;
        public uint permission; // = null;

        public long runtimeentityid; // = null;

        public McpePermissionRequest()
            {
                Id = 0xb9;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(runtimeentityid);
                WriteUnsignedVarInt(permission);
                Write(flagss);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeentityid = ReadLong();
                permission = ReadUnsignedVarInt();
                flagss = ReadShort();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeentityid = default;
                permission = default;
                flagss = default;
            }
    }