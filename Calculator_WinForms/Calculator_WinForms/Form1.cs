using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input1(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "1";
        }

        private void input2(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "2";
        }

        private void input3(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "3";
        }

        private void input4(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "4";
        }

        private void input5(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "5";
        }

        private void input6(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "6";
        }

        private void input7(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "7";
        }

        private void input8(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "8";
        }

        private void input9(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "9";
        }

        private void input0(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "0";
        }

        private void add(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "+";
        }

        private void subtract(object sender, EventArgs e)
        {

        }

        private void multiply(object sender, EventArgs e)
        {
            
        }

        private void divide(object sender, EventArgs e)
        {

        }

        private void equals(object sender, EventArgs e)
        {
            string problem = this.richTextBox1.Text;

            char[] problem_arr = problem.ToCharArray();

            
        }
    }
}
