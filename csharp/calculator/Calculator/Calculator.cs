using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Calculator
{
    public partial class Calculator : Form
    {
        double firstNum;
        string operation;
        bool isOperationPerformed = false; 

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double ParseNumber(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            text = text.Replace(',', '.');

            double result;
            // 12.5
            // 1.5E+3
            // -3 , +5
            // - (عدد منفی) 
            if (double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
                return result;
            // 2.5    2,5

            return 0;
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxResult.Text))
            {
                textBoxResult.Text = "0";
            }

            firstNum = ParseNumber(textBoxResult.Text);

            Button button = (Button)sender;
            operation = button.Text;
            isOperationPerformed = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
                if (textBoxResult.Text == "" || textBoxResult.Text == "0")
                {
                    textBoxResult.Text = "";
                }

                if (isOperationPerformed)
                {
                    textBoxResult.Clear();
                    isOperationPerformed = false;
                }

                Button b = (Button)sender;
                textBoxResult.Text += b.Text;
        }
        



        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNum = ParseNumber(textBoxResult.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    if (secondNum != 0)
                        result = firstNum / secondNum;
                    else
                        MessageBox.Show("Error: Divide By Zero!");
                    break;
                case "x^y":
                    result = Math.Pow(firstNum, secondNum);
                    break;
                case "%":
                    result = (firstNum * secondNum) / 100;
                    break;
                default:
                    return;
            }
            textBoxResult.Text = result.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            firstNum = 0;
            operation = "";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double num = ParseNumber(textBoxResult.Text);
            if (num >= 0)
            {
                textBoxResult.Text = Math.Sqrt(num).ToString();
            }
            else
            {
                MessageBox.Show("ERROR: Negative Number!");
            }
        }

        

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!textBoxResult.Text.Contains(".") && !textBoxResult.Text.Contains(","))
            {
                if (string.IsNullOrEmpty(textBoxResult.Text))
                {
                    textBoxResult.Text = "0.";
                }
                else
                {
                    textBoxResult.Text += ".";
                }
            }
        }
    }
}
