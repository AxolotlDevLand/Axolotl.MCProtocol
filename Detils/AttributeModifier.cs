namespace Axolotl;

public class AttributeModifier
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public int Operations { get; set; }
        public int Operand { get; set; }
        public bool Serializable { get; set; }

        public override string ToString()
            {
                return
                    $"{{Id: {Id}, Name: {Name}, Amount: {Amount}, Operations: {Operations}, Operand: {Operand}, Serializable: {Serializable}}}";
            }
    }