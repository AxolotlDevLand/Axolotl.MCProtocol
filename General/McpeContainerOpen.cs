#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeContainerOpen : Packet
    {
        public BlockCoordinates coordinates; // = null;
        public long runtimeEntityId; // = null;
        public byte type; // = null;

        public byte windowId; // = null;

        public McpeContainerOpen()
            {
                Id = 0x2e;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(windowId);
                Write(type);
                Write(coordinates);
                WriteSignedVarLong(runtimeEntityId);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                windowId = ReadByte();
                type = ReadByte();
                coordinates = ReadBlockCoordinates();
                runtimeEntityId = ReadSignedVarLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                windowId = default;
                type = default;
                coordinates = default;
                runtimeEntityId = default;
            }
    }