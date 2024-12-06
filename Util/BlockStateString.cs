namespace Axolotl.Util;

public class BlockStateString : IBlockState
    {
        public int Type { get; } = 8;
        public string Value { get; set; }
        public string Name { get; set; }

        protected bool Equals(BlockStateString other)
            {
                return string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase) &&
                       string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);
            }

        public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj))
                    return false;
                if (ReferenceEquals(this, obj))
                    return true;
                if (obj.GetType() != GetType())
                    return false;
                return Equals((BlockStateString)obj);
            }

        public override int GetHashCode()
            {
                return HashCode.Combine(GetType().Name, Name, Value.ToLowerInvariant());
            }

        public override string ToString()
            {
                return $"{nameof(Name)}: {Name}, {nameof(Value)}: {Value}";
            }
    }