#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeResourcePackDataInfo : Packet
    {
        public uint chunkCount; // = null;
        public ulong compressedPackageSize; // = null;
        public byte[] hash; // = null;
        public bool isPremium; // = null;
        public uint maxChunkSize; // = null;

        public string packageId; // = null;
        public byte packType; // = null;

        public McpeResourcePackDataInfo()
            {
                Id = 0x52;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(packageId);
                Write(maxChunkSize);
                Write(chunkCount);
                Write(compressedPackageSize);
                WriteByteArray(hash);
                Write(isPremium);
                Write(packType);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                packageId = ReadString();
                maxChunkSize = ReadUint();
                chunkCount = ReadUint();
                compressedPackageSize = ReadUlong();
                hash = ReadByteArray();
                isPremium = ReadBool();
                packType = ReadByte();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                packageId = default;
                maxChunkSize = default;
                chunkCount = default;
                compressedPackageSize = default;
                hash = default;
                isPremium = default;
                packType = default;
            }
    }