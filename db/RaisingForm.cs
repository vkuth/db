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
    public partial class RaisingForm : Form
    {
        public RaisingForm()
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
                main.bazeDataSet.Tables[0].Rows[r][4] = tbWork.Text;
                main.bazeDataSet.Tables[0].Rows[r][5] = tbDirector.Text;
                main.bazeDataSet.Tables[0].Rows[r][6] = tbSphere.Text;
                main.bazeDataSet.Tables[0].Rows[r][7] = tbDivision.Text;
                main.bazeDataSet.Tables[0].Rows[r][8] = tbCompany.Text;
                main.contactsTableAdapter.Update(main.bazeDataSet.contacts);
                main.bazeDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
            }
        }

        private void RaisingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "probaDataSet.contacts". При необходимости она может быть перемещена или удалена.
            this.contactsTableAdapter.Fill(this.probaDataSet.contacts);

        }
    }
}
