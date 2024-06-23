using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double currentNumber = 0;
        double memoryNumber = 0;
        char operation = ' ';

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtOutput.Text += btn0.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = '+';
            currentNumber = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = '-';
            currentNumber = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = '*';
            currentNumber = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!txtOutput.Text.Contains("."))
                txtOutput.Text += ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            currentNumber = 0;
            memoryNumber = 0;
            operation = ' ';
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = '/';
            currentNumber = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double result = 0;
            double secondNumber = double.Parse(txtOutput.Text);

            switch (operation)
            {
                case '+':
                    result = currentNumber + secondNumber;
                    break;
                case '-':
                    result = currentNumber - secondNumber;
                    break;
                case '*':
                    result = currentNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber != 0)
                        result = currentNumber / secondNumber;
                    else
                        txtOutput.Text = "0";
                    break;
            }
            txtOutput.Text = result.ToString();
        }
    }
}
