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
    public partial class Searchform2 : Form
    {
        public Searchform2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Form3 main = this.Owner as Form3;
            if (main != null)
            {
                if (tbStr.Text == "")
                {
                    MessageBox.Show("Введена пустая строка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int p = -1;
                    for (int i = 0; i < main.dataGridView1.RowCount; i++)
                    {
                        main.dataGridView1.Rows[i].Selected = false;
                        for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                            if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                                if (main.dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(tbStr.Text))
                                {
                                    main.dataGridView1.Rows[i].Selected = true;
                                    p++;
                                    break;
                                }


                    }
                    if (p == -1)
                    {
                        MessageBox.Show("Не найдено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
