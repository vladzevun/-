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

        private CustomStockPointList iАномальныеБары;

        //Здесь храняться бары отображаемые при нажатие Пред \ След кнопки
        private CustomStockPointList iОсобыеБары;

        private int iИндексОсобогоБара;

        private StockPt iВыбранныйБар;

        private LineItem iУказательНаГрафике;

        private int iГрафическихЭлементов;



        private c_СписокСекторов.c_СписокСегментов iСегменты;

        private c_СписокСекторов.c_СписокСегментов iСегменты_ВременнойСдвиг;



        private StockPt iБарНачалаФрагмента;

        private StockPt iБарКонцаФрагмента;

        private int iИндексТекущегоСегмента;


        private int iМаксОтрисовываемыхБаровНаСерию;


        private decimal iПоискГепов_КритерийГепа;
        private decimal iПоискГепов_ЧислоДнейВДелении;
        private decimal iПоискГепов_МножСреднего;
        private decimal iПоискГепов_КритерийСжожестиГеповЭталона;
        private bool iПоискГепов_ИгноритьЭталон;

        private decimal iПоискВременныхСдвигов_МножительСреднегоДляВысоты;
        private decimal iПоискВременныхСдвигов_ЧислоБаров;


        private decimal iПоискАномальныхБаров_КритерийРасхождения;
        private decimal iПоискАномальныхБаров_КритерийНулевогоБара;
        private bool iПоискАномальныхБаров_УчитыватьНулевыеБары;

        private decimal iУдалениеОдинокихБаров_ПорогМинут;





        
    }
}
