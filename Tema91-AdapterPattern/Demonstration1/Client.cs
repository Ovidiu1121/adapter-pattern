using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema91_AdapterPattern.Demonstration1
{
    public class Client
    {

        public Client()
        {
            Console.WriteLine("***Adapter Pattern Demo***\n");

            // A rectangle instance
            RectInterface rectangle = new Rectangle(20, 10);

            // A triangle instance
            TriInterface triangle = new Triangle(20, 10);

            // Using the adapter for the triangle object
            RectInterface adapter = new Adapter(triangle);

            // Holding all objects inside a list
            // It helps you traverse the list in
            // a uniform way.
            List<RectInterface> rectangleObjects = new List<RectInterface>();
            rectangleObjects.Add(rectangle);
            // rectangleObjects.Add(triangle);//Error
            rectangleObjects.Add(adapter); // No error

            Console.WriteLine("Processing the following objects:\n");

            foreach (RectInterface rectObject in rectangleObjects)
            {
                Console.WriteLine("Area: " + GetDetails(rectObject) + " square units.\n");
            }
        }
        static double GetDetails(RectInterface rectangle)
        {
            rectangle.aboutMe();
            return rectangle.calculateArea();
        }
    }
}
