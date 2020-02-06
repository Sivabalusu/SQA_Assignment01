using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAAssignment01
{
    class Rectangle
    {
        private int length;
        private int width;
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }
        public int GetLength()
        {
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int Area()
        {
            return length * width;
        }
    }
}
