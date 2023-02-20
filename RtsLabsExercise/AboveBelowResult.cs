namespace RtsLabsExercise
{
    public class AboveBelowResult : IEquatable<AboveBelowResult>
    {
        public AboveBelowResult(int above, int below)
        {
            Above = above;
            Below = below;
        }

        public int Above { get; }

        public int Below { get; }

        public bool Equals(AboveBelowResult? other)
        {
            if (ReferenceEquals(null, other)) { return false; }
            if (ReferenceEquals(this, other)) return true;

            return Above == other.Above && Below == other.Below;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;

            if (obj.GetType() != GetType()) return false;

            return Equals((AboveBelowResult)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Above, Below);
        }

        public override string ToString()
        {
            return $"Above: {Above}, Below: {Below}";
        }
    }
}