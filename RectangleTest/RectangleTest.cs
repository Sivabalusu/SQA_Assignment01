using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQAAssignment01;
using NUnit.Framework;

namespace RectangleTest
{
    [TestFixture]
    public class RectangleTest
    {
        Rectangle rectangle;

        [Test]
        public void SetLength_Input01_Output01()
        {
            rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetLength());
        }
        [Test]
        public void SetLength_Input02_Output02()
        {
            rectangle = new Rectangle(2,3);
            Assert.AreEqual(2, rectangle.GetLength());
        }
        [Test]
        public void SetLength_Input02_Output03()
        {
            rectangle = new Rectangle(3, 2);
            Assert.AreNotEqual(2, rectangle.GetLength());
        }
        [Test]
        public void SetWidth_Input01_Output01()
        {
            rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetWidth());
        }
        [Test]
        public void SetWidth_Input04_Output05()
        {
            rectangle = new Rectangle();
            rectangle.SetWidth(4);
            Assert.AreNotEqual(5, rectangle.GetWidth());
        }
        [Test]
        public void SetWidth_Input06_Output06()
        {
            rectangle = new Rectangle(8,6);
            Assert.AreEqual(6, rectangle.GetWidth());
        }

        [Test]
        public void GetLength_Input06_Output06()
        {
            rectangle = new Rectangle(6, 3);
            Assert.AreEqual(6, rectangle.GetLength());
        }

        [Test]
        public void GetLength_Input09_Output08()
        {
            rectangle = new Rectangle();
            rectangle.SetLength(9);
            Assert.AreNotEqual(6, rectangle.GetLength());
        }

        [Test]
        public void GetLength_Input01_Output01()
        {
            rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetLength());
        }

        [Test]
        public void GetWidth_Input06_Output06()
        {
            rectangle = new Rectangle(9, 6);
            Assert.AreEqual(6, rectangle.GetWidth());
        }

        [Test]
        public void GetWidth_Input05_Output06()
        {
            rectangle = new Rectangle();
            rectangle.SetWidth(5);
            Assert.AreNotEqual(6, rectangle.GetWidth());
        }

        [Test]
        public void GetWidth_Input01_Output01()
        {
            rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetWidth());
        }
        [Test]
        public void GetPeremeter_Input01_01_output04()
        {
            rectangle = new Rectangle();
            Assert.AreEqual(4, rectangle.GetPerimeter());
        }

        [Test]
        public void GetPeremeter_Input03_02_output10()
        {
            rectangle = new Rectangle(3,2);
            Assert.AreEqual(10, rectangle.GetPerimeter());
        }

        [Test]
        public void GetPeremeter_Input04_02_output12()
        {
            rectangle = new Rectangle();
            rectangle.SetLength(4);
            rectangle.SetWidth(2);
            Assert.AreEqual(12, rectangle.GetPerimeter());
        }

        [Test]
        public void GetArea_Input01_01_output01()
        {
            rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetArea());
        }

        [Test]
        public void GetArea_Input04_02_output08()
        {
            rectangle = new Rectangle(4,2);
            Assert.AreEqual(8, rectangle.GetArea());
        }

        [Test]
        public void GetArea_Input05_03_output012()
        {
            rectangle = new Rectangle();
            rectangle.SetLength(5);
            rectangle.SetWidth(3);
            Assert.AreNotEqual(12, rectangle.GetArea());
        }

    }
}
