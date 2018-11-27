using System;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            ConsoleApp1.Calc c = new ConsoleApp1.Calc();

            int res = c.Sum(5, 5);

            Assert.Equal(res, 5 + 5); 
        }
        [Fact]
        public void TestMethod2()
        {
            ConsoleApp1.Calc c = new ConsoleApp1.Calc();

            int res = c.Sum(5, 5);

            Assert.Equal(res, 5 + 5);
        }
    }
}
