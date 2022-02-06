using System;

namespace AbstractFactory_HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Type Mercedes Or Audi");
            string type = Console.ReadLine().ToLower();

            Tire tire = GetFactory(type).makeTire();
            Console.WriteLine(tire.getTire());

            Headlight headlight = GetFactory(type).makeHeadlight();
            Console.WriteLine(headlight.GetHeadlight());

                        
            
        }

        public static Factory GetFactory(string factoryname)
        {
            if (factoryname.Equals("audi"))
            {
                return new AudiFactory();
            }
            else if (factoryname.Equals("mercedes"))
            {
                return new MercedesFactory();
            }
            else return null;
        }

        
        
    }
}
