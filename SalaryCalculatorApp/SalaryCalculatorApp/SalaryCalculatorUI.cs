using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }
        SalaryCalculator aCalculator= new SalaryCalculator();
        private void button1_Click(object sender, EventArgs e)
        {
            aCalculator.name = nameTextBox.Text;
            aCalculator.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aCalculator.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            aCalculator.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double salary = aCalculator.CalculateSalary();
            MessageBox.Show(aCalculator.name + ", Your Salary is: " + salary);

        }
    }
}
