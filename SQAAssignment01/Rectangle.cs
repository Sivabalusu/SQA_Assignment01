﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAAssignment01
{
    public class Rectangle
    {
        private int length;
        private int width;
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }
        public Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }
        public int GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }
        public int GetArea()
        {
            return this.length * this.width;
        }
    }
}
