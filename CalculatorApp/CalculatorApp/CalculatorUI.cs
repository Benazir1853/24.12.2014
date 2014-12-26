using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }
      Calculator aCalculator =new Calculator();
        public double result;
      
        

        private void sumButton_Click(object sender, EventArgs e)
        {
            //aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            //aCalculator.secoundNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result =aCalculator.Add(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text));

            resultTextBox.Text = result.ToString();

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            //aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            //aCalculator.secoundNumber = Convert.ToDouble(secondNumberTextBox.Text);
           result= aCalculator.Subtract(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text));

            resultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            //aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            //aCalculator.secoundNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result=aCalculator.Multiply(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text));

            resultTextBox.Text =result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            //aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            //aCalculator.secoundNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result=aCalculator.Divide(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text));
            resultTextBox.Text = result.ToString();
        }
    }
}
