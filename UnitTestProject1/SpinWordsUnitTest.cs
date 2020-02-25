using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SpinWordsUnitTest
    {
        [TestMethod]
        public void Test_Miha()
        {
            Assert.AreEqual("emocleW", SpinWords.Solve("Welcome"));
            Assert.AreEqual("Hey wollef sroirraw", SpinWords.Solve("Hey fellow warriors"));
            Assert.AreEqual("This is a test", SpinWords.Solve("This is a test"));
            Assert.AreEqual("This is rehtona test", SpinWords.Solve("This is another test"));
            Assert.AreEqual("You are tsomla to the last test", SpinWords.Solve("You are almost to the last test"));
            Assert.AreEqual("Just gniddik ereht is llits one more", SpinWords.Solve("Just kidding there is still one more"));
        }
    }
}
