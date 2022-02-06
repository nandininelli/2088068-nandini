using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_HandsOn
{    
    //Product
    public class Sweets
    {
        private List<string> packages = new List<string>();

        public void Add(string sweet)
        {
            packages.Add(sweet);
        }

        public void Display()
        {
            if(packages.Count==3)
            {
                Console.WriteLine("\nChild Package");
            }
            else
            {
                Console.WriteLine("\nAdult Package");
            }
            
            foreach(string s in packages)
            {  
                Console.Write(s + "\t");
            }
            Console.WriteLine();

        }
    }
}
