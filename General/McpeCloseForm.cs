using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.MCProtocol.Packet
{

    public partial class McpeCloseForm : Packet
        {


            public McpeCloseForm()
                {
                    Id = 0x136;
                    IsMcpe = true;
                }

            protected override void EncodePacket()
                {
                    base.EncodePacket();

                    BeforeEncode();


                    AfterEncode();
                }

            partial void BeforeEncode();
            partial void AfterEncode();

            protected override void DecodePacket()
                {
                    base.DecodePacket();

                    BeforeDecode();


                    AfterDecode();
                }

            partial void BeforeDecode();
            partial void AfterDecode();

            protected override void ResetPacket()
                {
                    base.ResetPacket();

                }

        }

}
