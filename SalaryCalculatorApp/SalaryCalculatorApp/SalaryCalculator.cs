using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class SalaryCalculator
    {
        public string name;
        public double basicAmount;
        public double medicalAllowance;
        public double houseRent;

        public double CalculateSalary()
        {
            return basicAmount + GetHouseRent() + GetMedicalAllowance();
        }

        public double GetHouseRent()

        {
            return (houseRent/100)*basicAmount;
        }

        public double GetMedicalAllowance()
        {
            return (medicalAllowance/100)*basicAmount;
        }
    }
}
