using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema91_AdapterPattern.Demonstration1
{
    public class Triangle:TriInterface
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public double calculateTriangleArea()
        {
            return 0.5 * BaseLength * Height;
        }

        public void aboutTriangle()
        {
            Console.WriteLine("Shape type: Triangle.");
        }

    }
}
