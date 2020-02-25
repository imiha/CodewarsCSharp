using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LoveVsFriendshipUnitTest
    {
        [TestMethod]
        public void Test_Miha()
        {
            Assert.AreEqual(100, LoveVsFriendship.WordsToMarks("attitude"));
        }
    }
}
