using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilimsel_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double a, b;
        string z;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="") || (textBox1.Text.EndsWith(",")))
            {
                textBox1.Text += "";
            }
            else
            {
                textBox1.Text += ",";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "+";
            textBox1.Text = "";
            label1.Text = a + "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "-";
            textBox1.Text = "";
            label1.Text = a + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "*";
            textBox1.Text = "";
            label1.Text = a + "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "/";
            textBox1.Text = "";
            label1.Text = a + "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "%";
            textBox1.Text = "";
            label1.Text = a + "%";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {
                textBox1.Text.Replace("-", "+");
            }
            else if (textBox1.Text.StartsWith("+"))
            {
                textBox1.Text.Replace("+", "-");
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "x^y";
            textBox1.Text = "";
            label1.Text = a + "^";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "sqrt";
            label1.Text = a + "^(1/2)";
            textBox1.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "log";
            label1.Text = ("log(" + a + ")");
            textBox1.Text = Convert.ToString(Math.Log10(a));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int fak = 1;
            a = Convert.ToDouble(textBox1.Text);
            z = "n!";
            label1.Text = a + "!=";
            for (int i = 1; i <= a; i++)
            {
                fak = fak * i;
            }
            textBox1.Text = Convert.ToString(fak);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "ln";
            textBox1.Text = "";
            label1.Text = a + "ln(";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            z = "sin";
            label1.Text ="sin(";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            z = "cos";
            label1.Text = "cos(";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            z = "tan";
            label1.Text = "tan(";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            z = "cot";
            label1.Text = "cot(";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.E);
            label1.Text = "e=";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.PI);
            label1.Text = "PI=";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "x^2";
            label1.Text = a + "^2=";
            textBox1.Text = Convert.ToString(Math.Pow(a, 2));
        }

        private void button32_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            z = "x^3";
            label1.Text = a + "^3=";
            textBox1.Text = Convert.ToString(Math.Pow(a, 3));
        }
        private void button10_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            if (z == "")
            {
                MessageBox.Show("Öncelikle sayı girişi ve işlem seçimi yapınız \n\t\tUYARI");
            }
            else if (z == "+")
            {
                textBox1.Text = Convert.ToString(a + b);
                label1.Text = "";
            }
            else if (z == "-")
            {
                textBox1.Text = Convert.ToString(a - b);
                label1.Text = "";
            }
            else if (z == "*")
            {
                textBox1.Text = Convert.ToString(a * b);
                label1.Text = "";
            }
            else if (z == "/")
            {
                textBox1.Text = Convert.ToString(a / b);
                label1.Text = "";
            }
            else if (z == "%")
            {
                textBox1.Text = Convert.ToString(a % b);
                label1.Text = "";
            }
            else if (z == "x^y")
            {
                textBox1.Text = Convert.ToString(Math.Pow(a, b));
                label1.Text = a + "^" + b+"=";
            }
            else if (z == "ln")
            {
                textBox1.Text = Convert.ToString(a*(Math.Log(b)/Math.Log(Math.E)));
                label1.Text = a + "sin(" + b + ")=";
            }
            else if (z == "sin")
            {
                b=(((Math.PI)*b)/180.0);
                textBox1.Text=Convert.ToString(Math.Sin(b));
                label1.Text ="sin(" + b + ")=";
            }
            else if (z == "cos")
            {
                b = (((Math.PI) * b) / 180.0);
                textBox1.Text = Convert.ToString(Math.Cos(b));
                label1.Text = "cos(" + b + ")=";
            }
            else if (z == "tan")
            {
                b = ((Math.PI) * b) / 180.0;
                textBox1.Text = Convert.ToString(Math.Tan(b));
                label1.Text = "tan(" + b + ")";
            }
            else if (z == "cot")
            {
                b = (((Math.PI) * b) / 180.0);
                textBox1.Text = Convert.ToString(1 / Math.Tan(b));
                label1.Text = "cot(" + b + ")";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
