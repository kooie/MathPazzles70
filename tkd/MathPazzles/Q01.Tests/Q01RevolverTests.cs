using NUnit.Framework;

namespace Q01.Tests
{
    [TestFixture]
    public class Q01RevolverTests
    {
        [Test]
        public void ResolveTest()
        {
            var result = Q01Resolver.Resolve();
            TestContext.WriteLine(result);
        }
    }
}