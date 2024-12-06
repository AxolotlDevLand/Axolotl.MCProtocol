namespace Axolotl.Util;

public class BlockStateInt : IBlockState
    {
        public int Type { get; } = 3;
        public int Value { get; set; }
        public string Name { get; set; }

        protected bool Equals(BlockStateInt other)
            {
                return Name == other.Name && Value == other.Value;
            }

        public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj))
                    return false;
                if (ReferenceEquals(this, obj))
                    return true;
                if (obj.GetType() != GetType())
                    return false;
                return Equals((BlockStateInt)obj);
            }

        public override int GetHashCode()
            {
                return HashCode.Combine(GetType().Name, Name, Value);
            }

        public override string ToString()
            {
                return $"{nameof(Name)}: {Name}, {nameof(Value)}: {Value}";
            }
    }