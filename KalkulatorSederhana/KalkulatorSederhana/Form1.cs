using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSederhana
{
    public partial class Form1 : Form
    {
        string output, operation;
        string num1 = "0";
        string num2 = "0";
        double hasil = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += ".";
            textBox1.Text += output;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "4";
            textBox1.Text += output;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "1";
            textBox1.Text += output;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "2";
            textBox1.Text += output;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "3";
            textBox1.Text += output;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "5";
            textBox1.Text += output;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "6";
            textBox1.Text += output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "7";
            
                textBox1.Text += output;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "8";
          
                textBox1.Text += output;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "9";
           
                textBox1.Text += output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output += "0";
           
            textBox1.Text += output;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = output;
            operation = "+";
            output = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = output;
            operation = "-";
            output = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = output;
            operation = "*";
            output = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            output = string.Empty;
            num1 = string.Empty;
            num2 = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num2 = output;

            double x, y;

            x = Convert.ToDouble(num1);
            y = Convert.ToDouble(num2);

            if (operation == "+")
            {
                hasil = x + y;
                textBox1.Text = hasil.ToString();
            }

            else if (operation == "-")
            {
                hasil = x - y;
                textBox1.Text = hasil.ToString();
            }

            else if (operation == "*")
            {
                hasil = x * y;
                textBox1.Text = hasil.ToString();
            }

            else if (operation == "/")
            {
                if (y != 0)
                {
                    hasil = x / y;
                    textBox1.Text = hasil.ToString();
                }

                else
                {
                    textBox1.Text = "Infinity";
                }
            }

            hasil = 0;
            num1 = string.Empty;
            num2 = string.Empty;
            output = string.Empty;
            operation = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = output;
            operation = "/";
            output = string.Empty;
        }
    }
}
