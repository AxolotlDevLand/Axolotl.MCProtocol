#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeUpdateBlockSynced : Packet
    {
        public uint blockPriority; // = null;
        public uint blockRuntimeId; // = null;

        public BlockCoordinates coordinates; // = null;
        public uint dataLayerId; // = null;
        public long unknown0; // = null;
        public long unknown1; // = null;

        public McpeUpdateBlockSynced()
            {
                Id = 0x6e;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(coordinates);
                WriteUnsignedVarInt(blockRuntimeId);
                WriteUnsignedVarInt(blockPriority);
                WriteUnsignedVarInt(dataLayerId);
                WriteUnsignedVarLong(unknown0);
                WriteUnsignedVarLong(unknown1);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                coordinates = ReadBlockCoordinates();
                blockRuntimeId = ReadUnsignedVarInt();
                blockPriority = ReadUnsignedVarInt();
                dataLayerId = ReadUnsignedVarInt();
                unknown0 = ReadUnsignedVarLong();
                unknown1 = ReadUnsignedVarLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                coordinates = default;
                blockRuntimeId = default;
                blockPriority = default;
                dataLayerId = default;
                unknown0 = default;
                unknown1 = default;
            }
    }