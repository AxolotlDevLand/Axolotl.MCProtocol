namespace Axolotl;

public class RequestRecord
    {
        public byte ContainerId { get; set; }
        public List<byte> Slots { get; set; } = new();
    }