namespace Axolotl;

using System.Numerics;

public class AnimationKey
    {
        public bool ExecuteImmediate { get; set; }
        public bool ResetBefore { get; set; }
        public bool ResetAfter { get; set; }
        public Vector3 StartRotation { get; set; }
        public Vector3 EndRotation { get; set; }
        public uint Duration { get; set; }
    }