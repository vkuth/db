using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                int r = main.dataGridView1.CurrentRow.Index;
                main.bazeDataSet.Tables[0].Rows[r][1] = tbName.Text;
                main.bazeDataSet.Tables[0].Rows[r][2] = tbDate.Text;
                main.bazeDataSet.Tables[0].Rows[r][3] = tbSex.Text;
                main.contactsTableAdapter.Update(main.bazeDataSet.contacts);
                main.bazeDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
            }
        }
    }
}
