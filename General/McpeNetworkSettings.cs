#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeNetworkSettings : Packet
    {
        public enum Compression
            {
                Nothing = 0,
                Everything = 1
            }

        public bool clientThrottleEnabled; // = null;
        public float clientThrottleScalar; // = null;
        public byte clientThrottleThreshold; // = null;
        public short compressionAlgorithm; // = null;

        public short compressionThreshold; // = null;

        public McpeNetworkSettings()
            {
                Id = 0x8f;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(compressionThreshold);
                Write(compressionAlgorithm);
                Write(clientThrottleEnabled);
                Write(clientThrottleThreshold);
                Write(clientThrottleScalar);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                compressionThreshold = ReadShort();
                compressionAlgorithm = ReadShort();
                clientThrottleEnabled = ReadBool();
                clientThrottleThreshold = ReadByte();
                clientThrottleScalar = ReadFloat();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                compressionThreshold = default;
                compressionAlgorithm = default;
                clientThrottleEnabled = default;
                clientThrottleThreshold = default;
                clientThrottleScalar = default;
            }
    }