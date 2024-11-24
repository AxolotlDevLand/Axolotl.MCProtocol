#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeVideoStreamConnect : Packet
    {
        public byte action; // = null;
        public float frameSendFrequency; // = null;
        public int resolutionX; // = null;
        public int resolutionY; // = null;

        public string serverUri; // = null;

        public McpeVideoStreamConnect()
            {
                Id = 0x7e;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(serverUri);
                Write(frameSendFrequency);
                Write(action);
                Write(resolutionX);
                Write(resolutionY);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                serverUri = ReadString();
                frameSendFrequency = ReadFloat();
                action = ReadByte();
                resolutionX = ReadInt();
                resolutionY = ReadInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                serverUri = default;
                frameSendFrequency = default;
                action = default;
                resolutionX = default;
                resolutionY = default;
            }
    }