using System.Linq;

namespace Q01
{
    public static class PalindromeValidator
    {
        public static bool Validate(string candidate)
        {
            var lowerCandidate = candidate.ToLowerInvariant();
            return lowerCandidate.Zip(lowerCandidate.Reverse(), (normal, reverse) => normal.Equals(reverse))
                .All(result => result);
        }
    }
}
