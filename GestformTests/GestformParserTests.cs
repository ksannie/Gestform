using Gestform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GestformTests
{
    [TestClass]
    public class GestformParserTests
    {
        [TestMethod]
        public void TryParseTest()
        {
            var gestformParser = new GestformParser();
            List<int> numbers = new List<int>();
            Assert.IsTrue(gestformParser.TryParse("0", out numbers));
            Assert.IsTrue(gestformParser.TryParse("238", out numbers));
            Assert.IsTrue(gestformParser.TryParse("1,2,3,4,0,-999,1000,222,-347", out numbers));
            Assert.IsTrue(numbers[3] == 4);
            Assert.IsTrue(numbers[5] == -999);
            Assert.IsTrue(numbers[8] == -347);
            Assert.IsTrue(numbers.Count == 9);

            Assert.IsFalse(gestformParser.TryParse("1,2;3,4,0,-999,1000,222,-347", out numbers));
            Assert.IsTrue(numbers.Count == 0);

            Assert.IsFalse(gestformParser.TryParse("1,2,3,4,0,-999,1001,222,-347", out numbers));
            Assert.IsTrue(numbers.Count == 0);

            Assert.IsFalse(gestformParser.TryParse("1,2,3,4,0,-999,-1001,222,-347", out numbers));
            Assert.IsTrue(numbers.Count == 0);

            Assert.IsFalse(gestformParser.TryParse("", out numbers));
            Assert.IsTrue(numbers.Count == 0);

            Assert.IsFalse(gestformParser.TryParse("fdsf", out numbers));
            Assert.IsTrue(numbers.Count == 0);
        }
    }
}