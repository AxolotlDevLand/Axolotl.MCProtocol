#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeResourcePackChunkRequest : Packet
    {
        public uint chunkIndex; // = null;

        public string packageId; // = null;

        public McpeResourcePackChunkRequest()
            {
                Id = 0x54;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(packageId);
                Write(chunkIndex);

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

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                packageId = default;
                chunkIndex = default;
            }
    }