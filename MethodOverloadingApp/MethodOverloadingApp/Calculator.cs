using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingApp
{
    class Calculator
    {
        public double Add(double firstNo, double secondNo)
        {
            return firstNo + secondNo;
        }
        public double Add(double firstNo, double secondNo,double thirdNo)
        {
           // return firstNo + secondNo+ thirdNo;
            return Add(Add(firstNo, secondNo), thirdNo);
        }
    }
}
