using System.Collections.Generic;

namespace Q04
{
    public class Rod
    {
        private readonly int _length;
        public int Length => _length;

        public Rod(int length)
        {
            _length = length;
        }

        public IEnumerable<Rod> CutInHalf()
        {
            var halfLength = _length / 2;
            return new List<Rod>{ new Rod(halfLength), new Rod(_length - halfLength) };
        }
    }
}