using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using АнализГрафиков.c_ЛистТочек;
using АнализГрафиков.c_Серия;


namespace АнализГрафиков.c_ИсследовательГрафиков
{
    public partial class c_ИсследовательГрафиков : UserControl
    {
        //Здесь храниться объектов представляющий серию, см класс c_Серия
        private List<c_Серия.c_Серия> iСписокСерий;

        //Здесь храняться точки позывающие аномальные котировки
        private CustomStockPointList iАномальныеТочки;

        private CustomStockPointList iАномальныеТочки_Разрыв;

        private CustomStockPointList iАномальныеТочки_Время;

        private StockPt iВыбранныйБар;

        private int iИндексТекущейАномальнойТочки;

        private LineItem iУказательНаГрафике;
    }
}
