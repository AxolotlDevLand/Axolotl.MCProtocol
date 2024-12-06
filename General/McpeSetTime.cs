#pragma warning disable
namespace Axolotl.MCProtocol.Packet;
public partial class McpeSetTime : Packet
    {
        public int time; // = null;

        public McpeSetTime()
            {
                Id = 0x0a;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteSignedVarInt(time);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                time = ReadSignedVarInt();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                time = default;
            }
    }