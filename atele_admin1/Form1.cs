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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Создаем экземпляр новой формы
            this.Hide(); // Скрываем текущую форму
            form2.ShowDialog(); // Показываем новую форму в модальном режиме (блокирует текущую)
            this.Close(); // Закрываем текущую форму после закрытия Form2
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Создаем экземпляр новой формы
            this.Hide(); // Скрываем текущую форму
            form3.ShowDialog(); // Показываем новую форму в модальном режиме (блокирует текущую)
            this.Close();
        }
    }
}
