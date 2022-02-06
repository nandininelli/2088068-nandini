using System;

namespace Builder_HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {

            Director director = new Director();

            Builder b1 = new ConcreteBuilderAdult();
            Builder b2 = new ConcreteBuilderChild();

            director.Construct(b1);
            Sweets s1 = b1.GetSweets();
            s1.Display();

            

            director.Construct(b2);
            Sweets s2 = b2.GetSweets();
            s2.Display();

            Console.ReadLine();
        }


    }
}
