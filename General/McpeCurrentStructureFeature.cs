using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.MCProtocol.Packet
{
    public partial class McpeCurrentStructureFeature : Packet
        {

            public string currentStructureFeature;

            public McpeCurrentStructureFeature()
                {
                    Id = 0x13a;
                    IsMcpe = true;
                }

            protected override void EncodePacket()
                {
                    base.EncodePacket();

                    BeforeEncode();

                    Write(currentStructureFeature);

                    AfterEncode();
                }

            partial void BeforeEncode();
            partial void AfterEncode();

            protected override void DecodePacket()
                {
                    base.DecodePacket();

                    BeforeDecode();

                    currentStructureFeature = ReadString();

                    AfterDecode();
                }

            partial void BeforeDecode();
            partial void AfterDecode();

            protected override void ResetPacket()
                {
                    base.ResetPacket();

                    currentStructureFeature = default;
                }

        }

}
