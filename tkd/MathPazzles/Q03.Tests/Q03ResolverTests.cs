using NUnit.Framework;

namespace Q03.Tests
{
    [TestFixture]
    public class Q03ResolverTests
    {
        [Test]
        public void ResolveTest()
        {
            var result = Q03Resolver.Resolve();
            TestContext.WriteLine(string.Join(", ", result));
        }
    }
}
