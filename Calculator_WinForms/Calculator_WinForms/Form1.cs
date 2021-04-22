using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForms
{
    public partial class Form1 : Form
    {
        private bool isReplacing = false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void input1(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "1";
            else
                this.richTextBox1.Text += "1";

            isReplacing = false;
        }

        private void input2(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "2";
            else
                this.richTextBox1.Text += "2";

            isReplacing = false;
        }

        private void input3(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "3";
            else
                this.richTextBox1.Text += "3";

            isReplacing = false;
        }

        private void input4(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "4";
            else
                this.richTextBox1.Text += "4";

            isReplacing = false;
        }

        private void input5(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "5";
            else
                this.richTextBox1.Text += "5";

            isReplacing = false;
        }

        private void input6(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "6";
            else
                this.richTextBox1.Text += "6";

            isReplacing = false;
        }

        private void input7(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "7";
            else
                this.richTextBox1.Text += "7";

            isReplacing = false;
        }

        private void input8(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "8";
            else
                this.richTextBox1.Text += "8";

            isReplacing = false;
        }

        private void input9(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "9";
            else
                this.richTextBox1.Text += "9";

            isReplacing = false;
        }

        private void input0(object sender, EventArgs e)
        {
            if (isReplacing)
                this.richTextBox1.Text = "0";
            else
                this.richTextBox1.Text += "0";

            isReplacing = false;
        }

        private void add(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(this.richTextBox1.Text[this.richTextBox1.Text.Length - 1].ToString(), out number))
                this.richTextBox1.Text += "+";
            else
                this.richTextBox1.Text = Regex.Replace(this.richTextBox1.Text, "[-+/*]$", "+");

            isReplacing = false;
        }

        private void subtract(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(this.richTextBox1.Text[this.richTextBox1.Text.Length - 1].ToString(), out number))
                this.richTextBox1.Text += "-";
            else
                this.richTextBox1.Text = Regex.Replace(this.richTextBox1.Text, "[-+/*]$", "-");

            isReplacing = false;
        }

        private void multiply(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(this.richTextBox1.Text[this.richTextBox1.Text.Length - 1].ToString(), out number))
                this.richTextBox1.Text += "*";
            else
                this.richTextBox1.Text = Regex.Replace(this.richTextBox1.Text, "[-+/*]$", "*");

            isReplacing = false;
        }

        private void divide(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(this.richTextBox1.Text[this.richTextBox1.Text.Length - 1].ToString(), out number))
                this.richTextBox1.Text += "/";
            else
                this.richTextBox1.Text = Regex.Replace(this.richTextBox1.Text, "[-+/*]$", "/");

            isReplacing = false;
        }

        private void equals(object sender, EventArgs e)
        {
            string problem = this.richTextBox1.Text;
            char[] problem_arr = problem.ToCharArray();
            string number1 = "";
            string equation = "";
            string number2 = "";

            for (int i = 0; i < problem_arr.Length; i++)
            {
                if (Regex.IsMatch(this.richTextBox1.Text[i].ToString(), "[0-9]") && equation.Length == 0)
                    number1 += this.richTextBox1.Text[i].ToString();
                else if (!Regex.IsMatch(this.richTextBox1.Text[i].ToString(), "[0-9]"))
                    equation += this.richTextBox1.Text[i].ToString();
                else
                    number2 += this.richTextBox1.Text[i].ToString();
            }

            this.richTextBox1.Text = this.getAnswer(equation, number1, number2).ToString();

            isReplacing = true;
        }

        private int getAnswer(string equation, string number1, string number2)
        {
            if (equation == "+")
                return int.Parse(number1) + int.Parse(number2);
            else if (equation == "-")
                return int.Parse(number1) - int.Parse(number2);
            else if (equation == "/")
                return int.Parse(number1) / int.Parse(number2);
            else
                return int.Parse(number1) * int.Parse(number2);
        }

        private void clearAll(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        private void clearOne(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.richTextBox1.Text.Remove(this.richTextBox1.Text.Length - 1, 1);
        }
    }
}
