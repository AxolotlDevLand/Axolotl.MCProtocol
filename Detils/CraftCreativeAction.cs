namespace Axolotl;

public class CraftCreativeAction : ItemStackAction
    {
        public uint CreativeItemNetworkId { get; set; }
        public byte ClientPredictedResult { get; set; }
    }