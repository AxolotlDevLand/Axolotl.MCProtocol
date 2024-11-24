#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeInteract : Packet
    {
        public enum Actions
            {
                RightClick = 1,
                LeftClick = 2,
                LeaveVehicle = 3,
                MouseOver = 4,
                OpenNpc = 5,
                OpenInventory = 6
            }

        public byte actionId; // = null;
        public long targetRuntimeEntityId; // = null;

        public McpeInteract()
            {
                Id = 0x21;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(actionId);
                WriteUnsignedVarLong(targetRuntimeEntityId);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                actionId = ReadByte();
                targetRuntimeEntityId = ReadUnsignedVarLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                actionId = default;
                targetRuntimeEntityId = default;
            }
    }