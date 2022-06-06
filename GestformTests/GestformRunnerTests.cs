using System;
using System.Collections.Generic;
using System.IO;

using Gestform;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GestformTests
{
    [TestClass]
    public class GestformRunnerTests
    {
        [TestMethod]
        public void RunTest()
        {
            List<int> numbers = new List<int>() { 1,2,4,-999,1000,200,333,0,15,-20,8};

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var gestformRunner = new GestformRunner();
            gestformRunner.Run(numbers);
            string result = stringWriter.ToString();
            Assert.AreEqual(string.Format("1{0}2{0}4{0}Geste{0}Forme{0}Forme{0}Geste{0}Gestform{0}Gestform{0}Forme{0}8{0}", Environment.NewLine), result);
        }
    }
}