#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeResourcePackClientResponse : Packet
    {
        public enum ResponseStatus
            {
                Refused = 1,
                SendPacks = 2,
                HaveAllPacks = 3,
                Completed = 4
            }

        public ResourcePackIds resourcepackids; // = null;

        public byte responseStatus; // = null;

        public McpeResourcePackClientResponse()
            {
                Id = 0x08;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(responseStatus);
                Write(resourcepackids);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                responseStatus = ReadByte();
                resourcepackids = ReadResourcePackIds();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                responseStatus = default;
                resourcepackids = default;
            }
    }