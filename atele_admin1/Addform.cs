using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atele_admin1
{
    public partial class Addform : Form
    {
        public Addform()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            try
            {
                if (main != null)
                {
                    DataRow nRow = main.myateleDataSet.Tables[1].NewRow();
                    int rc = main.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = tbName.Text;
                    nRow[2] = tbFamilia.Text;
                    nRow[3] = tbOt.Text;
                    nRow[4] = tbPhone.Text;
                    main.myateleDataSet.Tables[1].Rows.Add(nRow);
                    main.клиентыTableAdapter.Update(main.myateleDataSet.Клиенты);
                    main.myateleDataSet.Tables[1].AcceptChanges();
                    main.dataGridView1.Refresh();
                    tbName.Text = "";
                    tbFamilia.Text = "";
                    tbOt.Text = "";
                    tbPhone.Text = "";
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка, введите корректные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
