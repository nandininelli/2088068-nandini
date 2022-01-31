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
         static async  Task Method1()
        {
            string s = await Method2();
            Console.WriteLine(s);
        }
         static async  Task<string> Method2()
        {
            
            Thread.Sleep(5000);
            return "Hello World";
        }
        static async Task Main(string[] args)
        {
            await Method1();
        }
    }
}
