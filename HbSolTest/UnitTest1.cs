using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HbSolTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WillItPass_Output_String()
        {
            // arrange
            var resultExpected = $@"1 3 N{Environment.NewLine}5 1 E";

            // act
            var resultMethod = HbSol.Program.GetResult();
            
            // assert
            Assert.AreEqual(resultExpected, resultMethod);
        }
    }
}
