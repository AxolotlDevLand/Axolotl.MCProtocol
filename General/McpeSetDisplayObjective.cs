#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSetDisplayObjective : Packet
    {
        public string criteriaName; // = null;
        public string displayName; // = null;

        public string displaySlot; // = null;
        public string objectiveName; // = null;
        public int sortOrder; // = null;

        public McpeSetDisplayObjective()
            {
                Id = 0x6b;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(displaySlot);
                Write(objectiveName);
                Write(displayName);
                Write(criteriaName);
                WriteSignedVarInt(sortOrder);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                displaySlot = ReadString();
                objectiveName = ReadString();
                displayName = ReadString();
                criteriaName = ReadString();
                sortOrder = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                displaySlot = default;
                objectiveName = default;
                displayName = default;
                criteriaName = default;
                sortOrder = default;
            }
    }