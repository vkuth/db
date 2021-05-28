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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazeDataSet.contacts". При необходимости она может быть перемещена или удалена.
            this.contactsTableAdapter.Fill(this.bazeDataSet.contacts);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.Update(bazeDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void SavetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.Update(bazeDataSet);
        }

        private void AddtoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm
            {
                Owner = this
            };
            af.Show();
        }

        private void FindtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm
            {
                Owner = this
            };
            sf.Show();
        }

        private void ExittoolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AbouttoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            About af = new About
            {
                Owner = this
            };
            af.Show();
        }

        private void ControltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Help af = new Help
            {
                Owner = this
            };
            af.Show();
        }

        private void Raise_Click(object sender, EventArgs e)
        {
            RaisingForm af = new RaisingForm
            {
                Owner = this
            };
            af.Show();
        }

        private void Raising_Click(object sender, EventArgs e)
        {
            RaisingForm af = new RaisingForm
            {
                Owner = this
            };
            af.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 4)|| (e.ColumnIndex == 5)|| (e.ColumnIndex == 6)|| (e.ColumnIndex == 7)|| (e.ColumnIndex == 8))
            {
                RaisingForm af = new RaisingForm
                {
                    Owner = this
                };
                af.Show();
            } else if ((e.ColumnIndex == 1) || (e.ColumnIndex == 2) || (e.ColumnIndex == 3))
            {
                Edit af = new Edit
                {
                    Owner = this
                };
                af.Show();
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Edit af = new Edit
            {
                Owner = this
            };
            af.Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
