using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl.MCProtocol.Packet
{
    public partial class McpeInventoryTransaction
    {
        public enum TriggerType
        {
            Unknown = 0,
            PlayerInput = 1,
            SimulationTick = 2,
        }
    }
}
