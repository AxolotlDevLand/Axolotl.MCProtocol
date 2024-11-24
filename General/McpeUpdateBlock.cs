#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeUpdateBlock : Packet
    {
        public enum Flags
            {
                None = 0,
                Neighbors = 1,
                Network = 2,
                Nographic = 4,
                Priority = 8,
                All = Neighbors | Network,
                AllPriority = All | Priority
            }

        public uint blockPriority; // = null;
        public uint blockRuntimeId; // = null;

        public BlockCoordinates coordinates; // = null;
        public uint storage; // = null;

        public McpeUpdateBlock()
            {
                Id = 0x15;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(coordinates);
                WriteUnsignedVarInt(blockRuntimeId);
                WriteUnsignedVarInt(blockPriority);
                WriteUnsignedVarInt(storage);

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
                storage = ReadUnsignedVarInt();

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
                storage = default;
            }
    }