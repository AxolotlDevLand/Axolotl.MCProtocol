namespace Axolotl;

public class ItemStackResponse
    {
        public int RequestId { get; set; }
        public StackResponseStatus Result { get; set; } = StackResponseStatus.Ok;
        public List<StackResponseContainerInfo> ResponseContainerInfos { get; set; } = new();
    }