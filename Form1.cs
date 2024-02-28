using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT4._2._2
{
    public partial class Form1 : Form
    {

        Calculator calculator = new Calculator();
        decimal num1; 
        decimal num2;
        string option;
        decimal result; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            
            num2 = decimal.Parse(txtDisplay.Text);
            if (option.Equals(btnplus.Text))
            {
                result = calculator.Add(num1, num2);
            }
            else if (option.Equals(btnminus.Text))
            {
                result = calculator.Subtract(num1, num2);
            }
            else if (option.Equals(btnmultiply.Text))
            {
                result = calculator.Multiply(num1, num2);
            }
            else if (option.Equals(btndivide.Text))
            {
                try
                {
                    result = calculator.Divide(num1, num2);
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return; 
                }
            }

            txtDisplay.Text = result.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = btnplus.Text;
            num1 = decimal.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = btnminus.Text;
            num1 = decimal.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            option = btnmultiply.Text;
            num1 = decimal.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = btndivide.Text;
            num1 = decimal.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }
    }
}
