using NUnit.Framework;

namespace NUnitCheatSheet
{
    [TestFixture]
    public class Misc
    {
        [Test]
        public void BasicTest()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void BasicFailedTest()
        {
            Assert.IsTrue(false);
        }
    }
}