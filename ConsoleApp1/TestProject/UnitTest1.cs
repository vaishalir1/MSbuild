using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace TestProject
{
      [TestClass]
        public class UnitTest1
        {
            private const string Expected = "Hello World! Hi!!";
            [TestMethod]
            public void TestMethod1()
            {
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    ConsoleApp1.Program.Main();

                    var result = sw.ToString().Trim();
                    Assert.AreEqual(Expected, result);
                }
            }
        //[TestMethod]
        //public void TestMethod()
        //{
        //    using (var sw = new StringWriter())
        //    {
        //        Console.SetOut(sw);
        //        ConsoleApp1.Program.Main();

        //        var result = sw.ToString().Trim();
        //        Assert.IsTrue(true);
        //        Assert.IsTrue(false);
        //    }
        //}
    }
   
}

