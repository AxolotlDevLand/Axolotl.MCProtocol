using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.MCProtocol.Packet
{
    using Nbts;

    public partial class McpeJigsawStructureData : Packet
        {

            public Nbt nbt;

            public McpeJigsawStructureData()
                {
                    Id = 0x139;
                    IsMcpe = true;
                }

            protected override void EncodePacket()
                {
                    base.EncodePacket();

                    BeforeEncode();

                    Write(nbt);

                    AfterEncode();
                }

            partial void BeforeEncode();
            partial void AfterEncode();

            protected override void DecodePacket()
                {
                    base.DecodePacket();

                    BeforeDecode();

                    nbt = ReadNbt();

                    AfterDecode();
                }

            partial void BeforeDecode();
            partial void AfterDecode();

            protected override void ResetPacket()
                {
                    base.ResetPacket();

                    nbt = default;
                }

        }

}
