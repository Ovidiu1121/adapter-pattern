using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema91_AdapterPattern.Demonstration1
{
    public class Adapter:RectInterface
    {

        private TriInterface triangle;

        public Adapter(TriInterface triangle)
        {
            this.triangle = triangle;
        }

        public void aboutMe()
        {
            triangle.aboutTriangle();
        }

        public double calculateArea()
        {
            return triangle.calculateTriangleArea();
        }

    }
}
