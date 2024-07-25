using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    public partial class Form2 : Form
    {
        // הגדרת מערך טפסים מסוג טופס2
        public List<Form2> Form;
        // הגדרת משתנה שיצביע לי על המיקום הנוכחי של הקטגוריה
        public int Position;

        // קונסטרקטור שמאכלס את הטפסים
        public Form2(List<Form2> Forms, int i, string category_name)
        {
            InitializeComponent();
            Form = Forms;
            Position = i;
            lblCategoryName.Text = category_name;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HostManager.GetDishesSummary(lblCategoryName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Position < Form.Count() - 1)
            {
                Form[Position + 1].Visible = true;           
            }
            else
            {
                Form[0].Visible = true;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Position > 0)
            {
                Form[Position - 1].Visible = true;
            }
            else
            {
                Form[Form.Count - 1].Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

