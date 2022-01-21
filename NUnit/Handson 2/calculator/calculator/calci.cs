using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public  class calci
    {
        public int Add(int firstNo, int secondNo)
        {
            return firstNo + secondNo;
        }



        public int Substract(int firstNo, int secondNo)
        {
            return firstNo - secondNo;
        }
        public int Multiply(int firstNo, int secondNo)
        {
            return firstNo * secondNo;
        }
        public double  Division(double firstNo, double secondNo)
        {
           
            if (secondNo == 0)
                throw new ArgumentException("Second parameter cant't be zero");
            return  firstNo / secondNo;
        }
    }
}
