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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
       
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    DataRow nRow = main.bazeDataSet.Tables[0].NewRow();
                    int rc = main.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = tbName.Text;
                    nRow[2] = tbDate.Text;
                    nRow[3] = tbSex.Text;
                    nRow[4] = tbWork.Text;
                    nRow[5] = tbDirector.Text;
                    nRow[6] = tbSphere.Text;
                    nRow[7] = tbDivision.Text;
                    nRow[8] = tbCompany.Text;
                    main.bazeDataSet.Tables[0].Rows.Add(nRow);
                    main.contactsTableAdapter.Update(main.bazeDataSet.contacts);
                    main.bazeDataSet.Tables[0].AcceptChanges();
                    main.dataGridView1.Refresh();
                    tbName.Text = "";
                    tbSex.Text = "";
                    tbWork.Text = "";
                    tbDirector.Text = "";
                    tbSphere.Text = "";
                    tbDivision.Text = "";
                    tbCompany.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazeDataSet.contacts". При необходимости она может быть перемещена или удалена.
            this.contactsTableAdapter1.Fill(this.bazeDataSet.contacts);

        }


    }
}
