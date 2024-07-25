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
    public partial class Form2 : Form
    {
        public List<Form2> Forms;
        public int Position;
        public string GuestName;
        public Form2(List<Form2> forms, int i, string categoryName, string guestName)
        {
            InitializeComponent();
            Forms = forms;
            Position = i;
            lblCategory.Text = categoryName;
            GuestName=guestName;
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dtgAllChoices.DataSource = GuestManager.GetDishesSummary(lblCategory.Text);
        }

        private void btnAddEnter_Click(object sender, EventArgs e)
        {
            string dishName;
            if (txtChoice.Text != "")
                dishName = txtChoice.Text;
            else
                dishName = dtgAllChoices.SelectedRows[0].Cells[0].FormattedValue.ToString();
            GuestManager.AddFood(dishName,lblCategory.Text,GuestName);
        }

        private void btnThePrevious_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Position > 0)
            {
                Forms[Position - 1].Visible = true;
            }
            else
            {
                Forms[Forms.Count - 1].Visible = true;
            }
        }
        private void btnTheNext_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Position < Forms.Count() - 1)
            {
                Forms[Position + 1].Visible = true;
            }
            else
            {
                Forms[0].Visible = true;
            }
        }
    }
}
