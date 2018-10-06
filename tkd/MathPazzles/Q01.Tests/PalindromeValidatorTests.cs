using NUnit.Framework;

namespace Q01.Tests
{
    [TestFixture]
    public class PalindromeValidatorTests
    {
        [TestCase("mom", true)]
        [TestCase("dad", true)]
        [TestCase("noon", true)]
        [TestCase("eye", true)]
        [TestCase("madam", true)]
        [TestCase("level", true)]
        [TestCase("kayak", true)]
        [TestCase("moon", false)]
        [TestCase("sun", false)]
        [TestCase("boy", false)]
        [TestCase("girl", false)]
        [TestCase("now", false)]
        [TestCase("test", false)]
        [TestCase("away", false)]
        public void ValidateTest(string target, bool expected)
        {
            var actual = PalindromeValidator.Validate(target);
            Assert.AreEqual(expected, actual);
        }
    }
}