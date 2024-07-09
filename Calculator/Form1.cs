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
        int num1;
        int num2;
        int result;
        String option;

        public Form1()
        {
            InitializeComponent();
        }

        public void equal()
        {
            num2 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            if (option == "+")
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }

            if (option == "-")
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();

            }

            if (option == "x")
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();

            }

            if (option == "%")
            {
                result = num1 / num2;
                textBox1.Text = result.ToString();

            }
        }

        public void add()
        {
            num1 = int.Parse(textBox1.Text);
            option = "+";
            textBox1.Text = "";
        }

        public void sub()
        {
            num1 = int.Parse(textBox1.Text);
            option = "-";
            textBox1.Text = "";
        }

        public void div()
        {
            num1 = int.Parse(textBox1.Text);
            option = "%";
            textBox1.Text = "";
        }

        public void mal()
        {
            num1 = int.Parse(textBox1.Text);
            option = "x";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           textBox1.Text = textBox1.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {           
            add();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            equal();
        }

        private void button20_Click(object sender, EventArgs e)
        {           
            sub();
        }

        private void button15_Click(object sender, EventArgs e)
        {            
            mal();
        }

        private void button19_Click(object sender, EventArgs e)
        {         
            div();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
    }
}
