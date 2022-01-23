using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace AsyncAwaitUsage1
{
    class Program
    {
        public static void Method1()
        {
            Method2();
        }
        public static void Method2()
        {
            Console.WriteLine("Hello world");

            Thread.Sleep(5000);
        }
        static void Main(string[] args)
        {
            Method1();
        }
    }
}