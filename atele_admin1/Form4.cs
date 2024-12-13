using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace atele_admin1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myateleDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.myateleDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myateleDataSet.Прайс". При необходимости она может быть перемещена или удалена.
            this.прайсTableAdapter.Fill(this.myateleDataSet.Прайс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myateleDataSet.Работники". При необходимости она может быть перемещена или удалена.
            this.работникиTableAdapter.Fill(this.myateleDataSet.Работники);

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form3 main = this.Owner as Form3;
            try {
                if (main != null)
                {
                    DataRow nRow = main.myateleDataSet.Tables[0].NewRow();
                    int rc = main.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = tbIdclients.Text;
                    nRow[2] = tbidwork.Text;
                    nRow[3] = tbUsl.Text;
                    nRow[4] = tbPrice.Text;
                    nRow[5] = tbDate1.Text;
                    nRow[6] = tbDate2.Text;
                    main.myateleDataSet.Tables[0].Rows.Add(nRow);
                    main.заказыTableAdapter.Update(main.myateleDataSet.Заказы);
                    main.myateleDataSet.Tables[0].AcceptChanges();
                    main.dataGridView1.Refresh();
                    tbIdclients.Text = "";
                    tbidwork.Text = "";
                    tbUsl.Text = "";
                    tbPrice.Text = "";
                    tbDate1.Text = "";
                    tbDate2.Text = "";
                } }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, введите корректные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получение значения из первого столбца (индекс 0) выбранной строки
                string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbidwork.Text = value;

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) //выбор клиента 
        {
            if (e.RowIndex >= 0)
            {
                // Получение значения из первого столбца (индекс 0) выбранной строки
                string value = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();

                tbIdclients.Text = value; 
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();

            string value2 = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();

           
            tbUsl.Text = value1; 
            tbPrice.Text = value2;
        }
    }
}
