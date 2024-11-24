using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.MCProtocol.Packet
{
    public partial class McpeAnimate : Packet
        {
            public float unknownFloat;

            partial void AfterDecode()
                {
                    if (actionId == 0x80 || actionId == 0x81)
                        {
                            unknownFloat = ReadFloat();
                        }
                }

            partial void AfterEncode()
                {
                    if (actionId == 0x80 || actionId == 0x81)
                        {
                            Write(unknownFloat);
                        }
                }
        }
}
