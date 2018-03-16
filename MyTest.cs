using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp4
{
   [TestFixture]
    class MyTest
    {
        [TestCase]
        public void  add()
        {
            Mymath math = new Mymath();
            Assert.AreEqual(3, math.Add(2,1),"Test add pass");

        }
            
        [TestCase]
        public void sub()
        {
            Mymath math = new Mymath();
            Assert.AreEqual(1, math.sub(2, 1),"Test sub pass");
        }
    }
}
