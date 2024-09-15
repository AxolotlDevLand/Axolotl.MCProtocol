using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Axolotl
{
    public class AnimationKey
    {
        public bool ExecuteImmediate { get; set; }
        public bool ResetBefore { get; set; }
        public bool ResetAfter { get; set; }
        public Vector3 StartRotation { get; set; }
        public Vector3 EndRotation { get; set; }
        public uint Duration { get; set; }
    }
}
