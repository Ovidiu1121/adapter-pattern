using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema91_AdapterPattern.Demonstration1
{
    public class Rectangle:RectInterface
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void aboutMe()
        {
            Console.WriteLine("Shape type: Rectangle.");
        }

        public double calculateArea()
        {
            return Length * Width;
        }

    }
}
