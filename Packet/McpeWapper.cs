using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.MCProtocol.Packet
{
	public partial class McpeWrapper : Packet
	{
		public ReadOnlyMemory<byte> payload; // = null;

        public void DeCode(ref byte[] bytes)
        {
            if (bytes[0] == 0xfe)
            {
                payload = bytes.Skip(1).ToArray();
               return;   
            }

            throw new Exception("this is not a true gamepacket");
        }

        partial void AfterEncode()
		{
			Write(payload);
		}

		partial void AfterDecode()
		{
			payload = ReadReadOnlyMemory(0, true);
		}
	}
}
