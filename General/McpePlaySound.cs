#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePlaySound : Packet
    {
        public BlockCoordinates coordinates; // = null;

        public string name; // = null;
        public float pitch; // = null;
        public float volume; // = null;

        public McpePlaySound()
            {
                Id = 0x56;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(name);
                Write(coordinates);
                Write(volume);
                Write(pitch);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                name = ReadString();
                coordinates = ReadBlockCoordinates();
                volume = ReadFloat();
                pitch = ReadFloat();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                name = default;
                coordinates = default;
                volume = default;
                pitch = default;
            }
    }