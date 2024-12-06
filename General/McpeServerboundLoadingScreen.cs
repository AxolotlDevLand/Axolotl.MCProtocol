using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.MCProtocol.Packet
{
    public partial class McpeServerboundLoadingScreen : Packet
        {
            public enum ServerboundLoadingScreenPacketType
                {
                    Unknown = 0,
                    StartLoadingScreen = 1,
                    StopLoadingScreen = 2,
                }

            public int loadingScreenType;
            public int? loadingScreenId;

            public McpeServerboundLoadingScreen()
                {
                    Id = 0x138;
                    IsMcpe = true;
                }

            protected override void EncodePacket()
                {
                    base.EncodePacket();

                    BeforeEncode();

                    WriteVarInt(loadingScreenType);
                    Write(loadingScreenId.HasValue); // is optional
                    if (loadingScreenId.HasValue)
                        {
                            Write(loadingScreenId.Value);
                        }

                    AfterEncode();
                }

            partial void BeforeEncode();
            partial void AfterEncode();

            protected override void DecodePacket()
                {
                    base.DecodePacket();

                    BeforeDecode();

                    loadingScreenType = ReadVarInt();
                    if (ReadBool())
                        {
                            loadingScreenId = ReadInt();
                        }

                    AfterDecode();
                }

            partial void BeforeDecode();
            partial void AfterDecode();

            protected override void ResetPacket()
                {
                    base.ResetPacket();

                    loadingScreenType = default;
                    loadingScreenId = default;
                }

        }

}
