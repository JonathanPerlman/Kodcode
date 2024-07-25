using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (lsbAllGuests.Items.Contains(txtUserName.Text))
                GuestManager.AddGuest(txtUserName.Text);   
                List<Form2> forms = new List<Form2>();
                List<string> Categoreis = GuestManager.GetCategories();
                for (int i = 0; i < Categoreis.Count(); i++)
                {
                    forms.Add(new Form2(forms, i, Categoreis[i], txtUserName.Text));
                }
                forms.First().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> guests = GuestManager.guests();

            foreach (string guest in guests)
            {
                lsbAllGuests.Items.Add(guest);

            }
            lsbAllGuests.DoubleClick += (Sender, E) =>
            {
                string selectItem = lsbAllGuests.SelectedItem.ToString();
                if (selectItem == "") return;
                txtUserName.Text = selectItem;

            };
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsbAllGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
