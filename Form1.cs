using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Calculator
{
    public partial class Cal_Form : Form
    {
        public Cal_Form()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calc = new DataTable();
                var ans = Calc.Compute(Output.Text, "");
                Output.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string w = Output.Text.ToString();
            int len= w.Length;
            if (Output.Text[--len] != '.')
            {
                Output.Text += ".";
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Output.Text += "/";
        }

        private void pow_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Pow(Double.Parse(Output.Text), 2);
                Output.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            Output.Text += "+";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }

        private void mod_Click(object sender, EventArgs e)
        {

        }

        private void multi_Click(object sender, EventArgs e)
        {
            Output.Text += "*";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Output.Text += "-";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Sqrt(Double.Parse(Output.Text));
                Output.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
