namespace Axolotl.MCProtocol.Packet;

public class SpawnSettings
    {
        public short BiomeType { get; set; }
        public string BiomeName { get; set; }
        public int Dimension { get; set; }
		
        public void Read(Packet packet)
            {
                BiomeType = packet.ReadShort();
                BiomeName = packet.ReadString();
                Dimension = packet.ReadVarInt();
            }

        public void Write(Packet packet)
            {
                packet.Write(BiomeType);
                packet.Write(BiomeName);
                packet.WriteVarInt(Dimension);
            }
    }