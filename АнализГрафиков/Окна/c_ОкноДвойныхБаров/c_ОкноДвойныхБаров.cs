using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АнализГрафиков.Окна.c_ОкноДвойныхБаров
{
    public partial class c_ОкноДвойныхБаров : Form
    {
        public ВыбраннаяОпция iВыбраннаяОпция = ВыбраннаяОпция.ЗаменитьБарамиСдвига;
        public c_ОкноДвойныхБаров()
        {
            InitializeComponent();
        }

        private void ob_ЗаменятьБарамиСдвига_Click(object sender, EventArgs e)
        {
            iВыбраннаяОпция = ВыбраннаяОпция.ЗаменитьБарамиСдвига;
        }

        private void ob_ЗаменитьБарамиСерии_Click(object sender, EventArgs e)
        {
            iВыбраннаяОпция = ВыбраннаяОпция.ЗаменитьБарамиСерии;
        }

        private void ob_Продолжить_Click(object sender, EventArgs e)
        {
            iВыбраннаяОпция = ВыбраннаяОпция.ПродожитьБезЗамены;
        }
    }

    public enum ВыбраннаяОпция
    {
        ЗаменитьБарамиСдвига,
        ЗаменитьБарамиСерии,
        ПродожитьБезЗамены
    }
}
