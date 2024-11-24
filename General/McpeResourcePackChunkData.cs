#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeResourcePackChunkData : Packet
    {
        public uint chunkIndex; // = null;

        public string packageId; // = null;
        public byte[] payload; // = null;
        public ulong progress; // = null;

        public McpeResourcePackChunkData()
            {
                Id = 0x53;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(packageId);
                Write(chunkIndex);
                Write(progress);
                WriteByteArray(payload);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                packageId = ReadString();
                chunkIndex = ReadUint();
                progress = ReadUlong();
                payload = ReadByteArray();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                packageId = default;
                chunkIndex = default;
                progress = default;
                payload = default;
            }
    }