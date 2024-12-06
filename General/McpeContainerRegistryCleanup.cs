using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.MCProtocol.Packet
{
    public partial class McpeContainerRegistryCleanup : Packet
        {

            public FullContainerName[] removedContainers;

            public McpeContainerRegistryCleanup()
                {
                    Id = 0x13d;
                    IsMcpe = true;
                }

            protected override void EncodePacket()
                {
                    base.EncodePacket();

                    BeforeEncode();

                    //Write(removedContainers);

                    AfterEncode();
                }

            partial void BeforeEncode();
            partial void AfterEncode();

            protected override void DecodePacket()
                {
                    base.DecodePacket();

                    BeforeDecode();

                    //removedContainers = ReadFullContainerNames();

                    AfterDecode();
                }

            partial void BeforeDecode();
            partial void AfterDecode();

            protected override void ResetPacket()
                {
                    base.ResetPacket();

                    removedContainers = default;
                }

        }

}
