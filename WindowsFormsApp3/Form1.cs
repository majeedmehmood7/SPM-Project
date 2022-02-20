using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{


    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sqrt(x).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {


            if (textBox1.Text!=string.Empty)
            {
                textBox2.Text= Postfix.infixToPostfix(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Incorrect Expression");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int i,f=1;
            int n = Convert.ToInt32(textBox1.Text);
            for(i=1;i<=n; i++)
            {
                f = f * i;
            }
            textBox1.Text = f.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);

            textBox1.Text = Math.Pow(x, 2).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text +="3.14";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=string.Empty)
            {
                double x = double.Parse(textBox1.Text);
                double y = Math.Sin(x);
                textBox1.Text = Math.Round(y, 4).ToString();
            }
            else
            {
                MessageBox.Show("please enter the value first");
            }            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                double x = double.Parse(textBox1.Text);
                double y = Math.Cos(x);
                textBox1.Text = Math.Round(y, 4).ToString();
            }
            else
            {
                MessageBox.Show("please enter the value first");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                double x = double.Parse(textBox1.Text);
                double y = Math.Tan(x);
                textBox1.Text = Math.Round(y, 4).ToString();
            }
            else
            {
                MessageBox.Show("please enter the value first");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = Math.Asin(x);
            textBox1.Text = y.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = Math.Acos(x);
            textBox1.Text = y.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = Math.Atan(x);
            textBox1.Text = y.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = 1 / x;
            textBox1.Text = y.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }
    }
}
    
 
