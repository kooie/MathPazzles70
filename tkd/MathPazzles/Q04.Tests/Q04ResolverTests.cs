using NUnit.Framework;

namespace Q04.Tests
{
    [TestFixture]
    public class Q04ResolverTests
    {
        [TestCase(8, 3)]
        [TestCase(20, 3)]
        [TestCase(100, 5)]
        public void ResolveTest(int length, int maxCutCount)
        {
            var result = Q04Resolver.Resolve(length, maxCutCount);
            TestContext.WriteLine(result);
        }
    }
}
