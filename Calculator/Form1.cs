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
        private TextBox selectedTexBox;
       
        public Form1()
        {
            InitializeComponent();
        }
   
        private void btnEquals_Click(object sender, EventArgs e)
        {
            // 1. convert `string` to `float`
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            // 2. Validate input  

            //3. Perform calculation

            switch(cmbOperator.Text)
            {
                case "+":
                    label2.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    label2.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    label2.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    // - Check that txtNumber 2 is not 0
                    if (num2 == 0)
                    {
                        label2.Text = "Cannot be divided by zero";
                        return;
                    }

                    label2.Text = (num1 / num2).ToString();
                    break;
                case "^":
                    label2.Text = (Math.Pow(num1, num2)).ToString();
                    break;
                //case "¹":
                  //  label2.Text = (Math.Sqrt(num1)).ToString();
                    //break;

            }

        }
        private void button_Click_Global(object sender, EventArgs e)
        {
            selectedTexBox.Text += ((Button)sender).Text;
        }

       private void textBox_Enter(object sender, EventArgs e)
        {
            selectedTexBox = sender as TextBox;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
