using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_HandsOn
{
    public class ShapeMaker
    {
        private Circle circle = new Circle();
        private Rectangle rectangle = new Rectangle();
        private Square square = new Square();

        public ShapeMaker()
        {

        }

        public void drawCircle()
        {
            
            Console.WriteLine("Drawing Circle Started");
            circle.draw();
            Console.WriteLine("Circle Drawing Completed");
            Console.WriteLine();
        }

        public void drawRectangle()
        {   
            Console.WriteLine("Drawing Rectangle Started");
            rectangle.draw();
            Console.WriteLine("Rectangle Drawing Completed");
            Console.WriteLine();
        }

        public void drawSqaure()
        {
            Console.WriteLine("Drawing Sqaure Started");
            square.draw();
            Console.WriteLine("Square Drawing Completed");
            Console.WriteLine();
        }
    }

   
}
