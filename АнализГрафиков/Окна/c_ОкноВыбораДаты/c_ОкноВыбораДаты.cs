using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АнализГрафиков.Окна.c_ОкноВыбораДаты
{
    public partial class c_ОкноВыбораДаты : Form
    {
        public c_ОкноВыбораДаты(DateTime _Дата)
        {
            InitializeComponent();

            ob_Год.Value = _Дата.Year;
            ob_Месяц.Value = _Дата.Month;
            ob_День.Value = _Дата.Day;
            ob_Час.Value = _Дата.Hour;
            ob_Минута.Value = _Дата.Minute;
            ob_Секунда.Value = _Дата.Second;
        }


        public DateTime iДата 
        { 
            get => new DateTime((int)ob_Год.Value, (int)ob_Месяц.Value, (int)ob_День.Value, (int)ob_Час.Value, (int)ob_Минута.Value, (int)ob_Секунда.Value); 
        }
    }
}
