using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isoperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((text_result.Text == "0" )|| (isoperationPerformed))
            {
                text_result.Clear();
            }

            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if(!text_result.Text.Contains("."))

                text_result.Text = text_result.Text + btn.Text;
            }
            else
                text_result.Text = text_result.Text + btn.Text;
                isoperationPerformed = false;

        }

        private void text_result_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (resultValue!=0)
            {
                button18.PerformClick();
                resultValue = Double.Parse(text_result.Text);
                operationPerformed = btn.Text;
                isoperationPerformed = true;
            }

            resultValue = Double.Parse(text_result.Text);
            operationPerformed = btn.Text;
            isoperationPerformed = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    text_result.Text = (resultValue + Double.Parse(text_result.Text)).ToString();
                    break;
                case "-":
                    text_result.Text = (resultValue - Double.Parse(text_result.Text)).ToString();
                    break;
                case "*":
                    text_result.Text = (resultValue * Double.Parse(text_result.Text)).ToString();
                    break;
                case "/":
                    text_result.Text = (resultValue / Double.Parse(text_result.Text)).ToString();
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            text_result.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            text_result.Clear();
            resultValue = 0;
        }

       
    }
}
