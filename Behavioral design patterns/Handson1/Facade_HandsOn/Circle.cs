using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_HandsOn
{
    class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw Circle"); ;
        }
    }

    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw Rectangle"); ;
        }
    }

    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw Square");
        }
    }

}
