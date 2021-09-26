using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АнализГрафиков.Окна.c_ОкноИзменитьПараметр
{
    public partial class c_ОкноИзменитьПараметр : Form
    {
        public decimal ЗначениеПараметра
        {
            get => ob_Параметр.Value;
        }

        public c_ОкноИзменитьПараметр(
            string _имяОкна = "Изменить параметр", 
            string _описаниеПараметра = "", 
            decimal _текущееЗначение = 0, 
            int _точекПослеЗапятой = 0,
            int _максимум = 1000000,
            int _минимум = 0)
        {
            InitializeComponent();
            Text = _имяОкна;
            ob_Описание.Text = _описаниеПараметра;
            ob_Параметр.DecimalPlaces = _точекПослеЗапятой;
            ob_Параметр.Maximum = _максимум;
            ob_Параметр.Minimum = _минимум;
            ob_Параметр.Value = _текущееЗначение;
        }

    }
}
