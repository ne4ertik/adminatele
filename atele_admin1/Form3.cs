using atele_admin1.myateleDataSetTableAdapters;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myateleDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.myateleDataSet.Заказы);

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            заказыTableAdapter.Update(myateleDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Создаем экземпляр новой формы
            this.Hide(); // Скрываем текущую форму
            form1.ShowDialog(); // Показываем новую форму в модальном режиме (блокирует текущую)
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Searchform2 f4 = new Searchform2();
            f4.Owner = this;
            f4.Show();
        }

        private void Deleteorder(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
