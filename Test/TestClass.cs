using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQAAssignment01;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    class TestClass
    {
        Rectangle rectangle = new Rectangle();
        [Test]
        public void SetLength_input02_output02()
        {
            Assert.AreEqual(2, rectangle.GetLength());
        }
    }
}
