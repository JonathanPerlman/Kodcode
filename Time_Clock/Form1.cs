using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            // Collect TezBox inputs from form
            string result = EmployeeManager.Login(textBox1.Text, textBox2.Text, textBox3.Text);

            MessageBox.Show(result);


        }

       

        private void BtnChange_Click(object sender, EventArgs e)
        {
                var ChangePassword = new ChangePassword();
                ChangePassword.ShowDialog();
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
