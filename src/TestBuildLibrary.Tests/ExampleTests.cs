using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestBuildLibrary.Tests
{
    [TestFixture]
    public class ExampleTests
    {
        [Test]
        public void TestGetFibonacciNumber()
        {
            var example = new Example();
            Assert.AreEqual(55, example.GetFibonacciNumber(10));
        }
    }
}
