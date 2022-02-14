using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private  int length;
        private  int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int Length, int Width)
        {
            length = Length;
            width = Width;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLenght(int Length)
        {
            length = Length;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int Width)
        {
            width = Width;
            return width;
        }

        public int GetPerimeter()
        {
            
            int newWidth = width * 2;
            int newLength = length * 2;
            int perimeter = newWidth + newLength;
            return perimeter;

        }

        public int GetArea()
        {
            int Area = length * width;
            return Area;
        }

    }
}
