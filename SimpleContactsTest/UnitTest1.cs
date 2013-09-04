using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleContactsTest
{
    [TestClass]
    public class UnitTest1
    {
        public class Car
        {
            public int NumberOfDoors { get; set; }
            public string Engine { get; set; }
            public int Wheels { get; set; }
        
    
        }
        
        
        public TestContext TestContext { get; set; }

        private Car nicksCar;

        [TestMethod]
        public void TestMethod1()
        {
            nicksCar = new Car();
            nicksCar.Engine = "Really slow 4 cylinder";
            nicksCar.NumberOfDoors = 4;

            TestMethod2();
        }

        [TestMethod]
        public void TestMethod2()
        {
            nicksCar.Engine = "this is a new engine";
            TestContext.WriteLine(nicksCar.Engine);
        }
    }
}
