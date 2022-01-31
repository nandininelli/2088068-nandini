using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace AsyncOptionalParameters
{
    class Program
    {
        
            public static void OrderDetails(string sellerName, string productName, int OrderQuantity = 1, bool isreturnable = true)
            {
                Console.WriteLine($"Here is the order detail-{OrderQuantity} number of {productName} by {sellerName} is ordered.It's returnable status is {isreturnable}");
                Thread.Sleep(5000);
            }
            static void Main(string[] args)
            {
                OrderDetails("Nandini", "Ice Cream");
                OrderDetails("Nandi", "Ice cream", 2, false);
            }
        }
    }

