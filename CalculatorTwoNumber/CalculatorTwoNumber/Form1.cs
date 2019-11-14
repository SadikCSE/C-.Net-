using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTwoNumber
{
    public partial class Form1 : Form
    {
        private double firstNumber, secondNumber, result;
		
        public Form1()
        {
            InitializeComponent();
        }
         private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            input();
            result = firstNumber + secondNumber;
            output(result);
        }
        private void Sub_Click(object sender, EventArgs e)
        {
            input();
            result = firstNumber - secondNumber;
            output(result);
        }
        private void Mul_Click(object sender, EventArgs e)
        {
            input();
            result = firstNumber * secondNumber;
            output(result);
        }
         private void Div_Click(object sender, EventArgs e)
        {
            input();
            result = firstNumber / secondNumber;
            output(result);
        }
        private void output(double result)
        {
            resultBox.Text = result.ToString();
        }
        private void input()
        {
            firstNumber = double.Parse(textBox1.Text);
            secondNumber = double.Parse(textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
