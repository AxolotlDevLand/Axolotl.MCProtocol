namespace Axolotl;

public abstract class GameRule
    {
        protected GameRule(string name)
            {
                Name = name;
            }

        public string Name { get; }
        public bool IsPlayerModifiable { get; set; } = true;

        protected bool Equals(GameRule other)
            {
                return string.Equals(Name, other.Name);
            }

        public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != GetType()) return false;
                return Equals((GameRule)obj);
            }

        public override int GetHashCode()
            {
                return Name != null ? Name.GetHashCode() : 0;
            }
    }