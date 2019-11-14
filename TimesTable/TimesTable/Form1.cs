using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loopsubmit_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            int answer;

            for (int i = int.Parse(loopStart.Text); 
                i <= int.Parse(loopEnd.Text); i++)
            {

                answer = int.Parse(loopEnd.Text) * i;

                listBox1.Items.Add(i + " * " + int.Parse(loopEnd.Text) + " = " + answer.ToString());

            }
        }
    }
}
