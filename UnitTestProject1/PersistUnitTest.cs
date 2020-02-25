using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PersistUnitTest
    {
        [TestMethod]
        public void Test_Miha()
        {
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }

        [TestMethod]
        public void Test_Chris_fqs()
        {
            Assert.AreEqual(3, Persist.Persistence_Chris_fqs(39));
            Assert.AreEqual(0, Persist.Persistence_Chris_fqs(4));
            Assert.AreEqual(2, Persist.Persistence_Chris_fqs(25));
            Assert.AreEqual(4, Persist.Persistence_Chris_fqs(999));
        }

        [TestMethod]
        public void Test_Brutus9()
        {
            Assert.AreEqual(3, Persist.Persistence_Brutus9(39));
            Assert.AreEqual(0, Persist.Persistence_Brutus9(4));
            Assert.AreEqual(2, Persist.Persistence_Brutus9(25));
            Assert.AreEqual(4, Persist.Persistence_Brutus9(999));
        }
    }
}
