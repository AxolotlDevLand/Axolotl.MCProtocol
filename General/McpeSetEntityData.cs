#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetEntityData : Packet
    {
        public MetadataDictionary metadata; // = null;

        public long runtimeEntityId; // = null;
        public PropertySyncData syncdata; // = null;
        public long tick; // = null;

        public McpeSetEntityData()
            {
                Id = 0x27;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                Write(metadata);
                Write(syncdata);
                WriteUnsignedVarLong(tick);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                metadata = ReadMetadataDictionary();
                syncdata = ReadPropertySyncData();
                tick = ReadUnsignedVarLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId = default;
                metadata = default;
                syncdata = default;
                tick = default;
            }
    }