namespace Axolotl.Util;

using Newtonsoft.Json;

public class BlockStateContainer
    {
        public int Id { get; set; }
        public short Data { get; set; }
        public string Name { get; set; }
        public int RuntimeId { get; set; }
        public List<IBlockState> States { get; set; } = new();

        [JsonIgnore] public byte[] StatesCacheNbt { get; set; }

        public ItemPickInstance ItemInstance { get; set; }

        protected bool Equals(BlockStateContainer other)
            {
                bool result = /*Id == other.Id && */Name == other.Name;
                if (!result) return false;

                HashSet<IBlockState> thisStates = new(States);
                HashSet<IBlockState> otherStates = new(other.States);

                otherStates.IntersectWith(thisStates);
                result = otherStates.Count == thisStates.Count;

                return result;
            }

        public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != GetType()) return false;
                return Equals((BlockStateContainer)obj);
            }

        public override int GetHashCode()
            {
                HashCode hash = new();
                hash.Add(Id);
                hash.Add(Name);
                foreach (IBlockState state in States)
                    switch (state)
                        {
                            case BlockStateByte blockStateByte:
                                hash.Add(blockStateByte);
                                break;
                            case BlockStateInt blockStateInt:
                                hash.Add(blockStateInt);
                                break;
                            case BlockStateString blockStateString:
                                hash.Add(blockStateString);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(state));
                        }

                int hashCode = hash.ToHashCode();
                return hashCode;
            }

        public override string ToString()
            {
                return
                    $"{nameof(Name)}: {Name}, {nameof(Id)}: {Id}, {nameof(Data)}: {Data}, {nameof(RuntimeId)}: {RuntimeId}, {nameof(States)} {{ {string.Join(';', States)} }}";
            }
    }