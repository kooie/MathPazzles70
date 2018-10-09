using System.Collections.Generic;
using System.Linq;

namespace Q04
{
    public class RodCuttingService
    {
        private readonly List<Rod> _rods;

        public bool Completed => _rods.All(rod => rod.Length == 1);


        public RodCuttingService(Rod rod)
            : this(new List<Rod> { rod })
        {

        }

        private RodCuttingService(List<Rod> rods)
        {
            _rods = rods;
        }

        public RodCuttingService RequestToCut(int maxCutCount)
        {
            var (lengthOneList, otherList) = DivideIntoGroup();
            var result = new List<Rod>(lengthOneList);

            var otherListCount = otherList.Count;
            if (otherListCount < maxCutCount)
            {
                var list = CreateCutResult(otherListCount, otherList);
                result.AddRange(list);
            }
            else
            {
                var list = CreateCutResult(maxCutCount, otherList);
                result.AddRange(list);
                var remainder = otherList.GetRange(maxCutCount, otherListCount - maxCutCount);
                result.AddRange(remainder);
            }
            return new RodCuttingService(result);
        }

        private static IEnumerable<Rod> CreateCutResult(int cutCount, IReadOnlyList<Rod> rods)
        {
            return Enumerable.Range(0, cutCount)
                .SelectMany(i => rods[i].CutInHalf())
                .ToList();
        }

        private (List<Rod> lengthOneList, List<Rod> otherList) DivideIntoGroup()
        {
            var groups = _rods.GroupBy(rod => rod.Length == 1)
                .ToDictionary(grouping => grouping.Key, grouping => grouping.ToList());
            var lengthOneList = groups.ContainsKey(true) ? groups[true] : new List<Rod>();
            return (lengthOneList, groups[false]);
        }



    }
}