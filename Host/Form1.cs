using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // יצירת מערך מסוג טופס2
           List<Form2> forms = new List<Form2>();
            // שליפת הקטגוריות מה db והכנסתם לתוך המערך
           List <string> Categoreis  =HostManager.GetCategories();
            // לולאה שעוברת על הקטגוריות ויוצרת טופס עבור כל קטגורינ
           for (int i = 0; i < Categoreis.Count(); i++) 
            {
                forms.Add(new Form2(forms, i, Categoreis[i]));
            }
           // הצגת הטופס הראשון כשהתכנית רצה
            forms.First().Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> categories = HostManager.GetCategories();

            foreach (string category in categories)
            {
                lsbCategory.Items.Add(category);

            }
            lsbCategory.DoubleClick += (Sender, E) =>
            {
                string selectItem = lsbCategory.SelectedItem.ToString();
                if (selectItem == "") return;
                txtCategorySelection.Text = selectItem;

            };
        }



        private void txtCategorySelection_TextChanged_1(object sender, EventArgs e)
        {
            List<string> categories = HostManager.GetFilteredCategories(txtCategorySelection.Text);
            lsbCategory.Items.Clear();
            foreach (string category in categories)
            {
                lsbCategory.Items.Add(category);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategorySelection.Text))
            {
                
                if (!lsbCategory.Items.Contains(txtCategorySelection.Text))
                {
                   
                    HostManager.InsertCategory(txtCategorySelection.Text);

                    lsbCategory.Items.Add(txtCategorySelection.Text);
                }
                else
                {
                    MessageBox.Show("הקטגוריה כבר קיימת ");
                }
            }
            else
            {
                MessageBox.Show("אנא הזן קטגוריה");
            }

        }

        private void btnCategoryEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategorySelection.Text))
            {

                if (lsbCategory.Items.Contains(txtCategorySelection.Text))
                {

                    HostManager.DeleteCategory(txtCategorySelection.Text);

                    lsbCategory.Items.Remove(txtCategorySelection.Text);
                }
                else
                {
                    MessageBox.Show("הקטגוריה אינה קיימת ");
                }
            }
            else
            {
                MessageBox.Show("אנא הזן קטגוריה");
            }
        }

        private void lsbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }





       
