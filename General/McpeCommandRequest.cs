#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeCommandRequest : Packet
    {
        public string command; // = null;
        public uint commandType; // = null;
        public bool isinternal; // = null;
        public string requestId; // = null;
        public UUID unknownUuid; // = null;
        public int version; // = null;

        public McpeCommandRequest()
            {
                Id = 0x4d;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(command);
                WriteUnsignedVarInt(commandType);
                Write(unknownUuid);
                Write(requestId);
                Write(isinternal);
                WriteSignedVarInt(version);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                command = ReadString();
                commandType = ReadUnsignedVarInt();
                unknownUuid = ReadUUID();
                requestId = ReadString();
                isinternal = ReadBool();
                version = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                command = default;
                commandType = default;
                unknownUuid = default;
                requestId = default;
                isinternal = default;
                version = default;
            }
    }