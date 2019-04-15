using System;
using AS2805._6._5._3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompartKeyBlocks()
        {
           ISO20038 keyblock = new ISO20038();
           keyblock.runTest();
        }
    }
}
