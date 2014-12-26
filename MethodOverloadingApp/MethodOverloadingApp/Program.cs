using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator=new Calculator();
            aCalculator.Add(12, 13);

        }
    }
}
