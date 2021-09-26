using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АнализГрафиков.Окна.c_ОкноПоискаВременныхСдвигов
{
    public partial class c_ОкноПоисковВременныхСдвигов : Form
    {
        public c_ОкноПоисковВременныхСдвигов(decimal _ЧислоБаров = 10, decimal _МножительСреднегоДляВысоты = 2)
        {
            InitializeComponent();

            ob_МножительСреднегоДляВысоты.Value = _МножительСреднегоДляВысоты;
            ob_ЧислоБаров.Value = _ЧислоБаров;

            ob_ВсплывающаяПодсказка.SetToolTip(ob_ЧислоБаров,
                "Число баров в одном сегменте");

            ob_ВсплывающаяПодсказка.SetToolTip(ob_МножительСреднегоДляВысоты,
                "Формула: Если средняя разница цены отрытия главной и донорской серии больше средней высоты баров главной умноженой на Множитель среднего, то участок сегмент имеет сдвиг");
            
        }



        public decimal iЧислоБаров { get => ob_ЧислоБаров.Value; }

        public decimal iМножительСреднегоДляВысоты { get => ob_МножительСреднегоДляВысоты.Value; }
    }
}
