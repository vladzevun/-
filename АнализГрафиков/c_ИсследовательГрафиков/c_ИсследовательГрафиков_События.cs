using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;
using АнализГрафиков.c_ЛистТочек;

namespace АнализГрафиков.c_ИсследовательГрафиков
{
    public partial class c_ИсследовательГрафиков
    {
        public c_ИсследовательГрафиков()
        {
            InitializeComponent();

            iСписокСерий = new List<c_Серия.c_Серия>();

            iОсобыеБары = new CustomStockPointList();

            iИндексОсобогоБара = -1;

            iСегменты = null;

            iСегменты_ВременнойСдвиг = null;

            iИндексТекущегоСегмента = -1;

            iГрафическихЭлементов = 1;

            iПоискГепов_КритерийГепа = 10.00M;
            iПоискГепов_ЧислоДнейВДелении = 3M;
            iПоискГепов_МножСреднего = 2M;
            iПоискГепов_ИгноритьЭталон = false;
            iПоискГепов_КритерийСжожестиГеповЭталона = 1.5M;

            iПоискВременныхСдвигов_МножительСреднегоДляВысоты = 3.00M;
            iПоискВременныхСдвигов_ЧислоБаров = 1440M;

            iПоискАномальныхБаров_КритерийРасхождения = 3M;
            iПоискАномальныхБаров_КритерийНулевогоБара = 5M;
            iПоискАномальныхБаров_УчитыватьНулевыеБары = true;

            iУдалениеОдинокихБаров_ПорогМинут = 5M;

            iМаксОтрисовываемыхБаровНаСерию = 5000;

            //Эту кривую ипользум как визульный указатель на бар
            iУказательНаГрафике = new LineItem("Указатель", new PointPairList(), Color.Black, SymbolType.TriangleDown);

            //Не отображам в легенде, это излишнее
            iУказательНаГрафике.Line.IsVisible = false;
            iУказательНаГрафике.Label.IsVisible = false;
            iУказательНаГрафике.AddPoint(0, 0);

            //Чтоб не ломалась работа с индексами
            iСписокСерий.Add(new c_Серия.c_Серия());

            //Чтоб не ломалась работа с индексами
            ob_График.GraphPane.CurveList.Add(iУказательНаГрафике);

            //Добавляем в листбос для возможности отключить его отрисовку и чтоб не ломалась работа с индексами всей программы
            ob_ЛистБоксСерий.Items.Add(iУказательНаГрафике.Label.Text, true);

            

            #region Инициализация внешних параметров графика

            //Для удобства инициализации
            var График = ob_График.GraphPane;

            //Название графика
            График.Title.Text = "Редакция истории";

            //Название оси X
            График.XAxis.Title.Text = "Дата";
            //Название оси Y
            График.YAxis.Title.Text = "Сумма";

            //Бэкграунд графика
            График.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);
            //Бэкграунд zed controla вне графика
            График.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45.0f);

            

            //Ось X изменялась по дате
            График.XAxis.Type = AxisType.Date;

            //Ось формат данных по оси Х
            График.XAxis.Scale.Format = "dd-MM-yyyy hh-mm";
                      

            #endregion

            #region Настройка подсказок

            ob_ВсплывающаяПодсказка.SetToolTip(ob_ПоискГепов, 
                "Выполняет поиск гепов\n" +
                "Для просмотра гепов, использовать кнопки Пред | След");
            

            ob_ВсплывающаяПодсказка.SetToolTip(ob_НайтиАномальныеБары,
                "Формула:\n" +
                "ГлавнаяДельта = |ГлавныйБар.ЦенаОткрытия - ГлавныйБар.ЦенаЗакрытия|\n" +
                "ПобочнаяДельта = |ДонорскийБар.ЦенаОткрытия - ДонорскийБар.ЦенаЗакрытия|\n" +
                "Бар аномален, если: (ПобочнаяДельта / ГлавнаяДельта > КритерийРасхождения) или (ГлавнаяДельта / ПобочнаяДельта > КритерийРасхождения)");

            ob_ВсплывающаяПодсказка.SetToolTip(ob_Сегменты_ЗаменятьБарамиСдвига,
                "При нажатии Удалить двойные текущего сегмента и Удалить двойные бары всех сегментов\n" +
                "Да - Если бары сдвига идут \"внахлёст\" барам за сегментом, они будут заменены барами сегмета\n" +
                "Нет - Если бары сдвига идут \"внахлёст\" барам за сегментом, бары сегмента будут удалены");

            ob_ВсплывающаяПодсказка.SetToolTip(ob_БарыБольшеДонорской,
                "Ищет все бары, цена открытия которых отличается от цены открытия донорской. Степень отличия задаётся критерием отклонения");

            ob_ВсплывающаяПодсказка.SetToolTip(ob_КритерийОтклонения,
                "Если отношение цены открытия большего бара к цене открытия мешьшего больше критерия отклонения, то показываем такой бар ");





            #endregion

            #region DEBUG


            //f_Серия_ЗагрузитьИзФайла(@"C:\Users\ulad\source\repos\АнализГрафиков\АнализГрафиков\bin\Debug\Series1TestM.csv");
            //f_Серия_ЗагрузитьИзФайла(@"C:\Users\ulad\source\repos\АнализГрафиков\АнализГрафиков\bin\Debug\Series1TestFinam.csv");

            //f_Серия_ЗагрузитьИзФайла(@"C:\Users\ulad\source\repos\АнализГрафиков\АнализГрафиков\bin\Debug\BTCUSD_M1_Short_200k.csv");
            //f_Серия_ЗагрузитьИзФайла(@"C:\Users\ulad\source\repos\АнализГрафиков\АнализГрафиков\bin\Debug\BTCUSD_finam_M1_Short_200k.csv");

            //f_Серия_ЗагрузитьИзФайла(@"C:\Users\ulad\source\repos\АнализГрафиков\АнализГрафиков\bin\Debug\BTCUSD.a_M1_201601010000_202107052301.csv");
            //f_Серия_ЗагрузитьИзФайла(@"C:\Users\ulad\source\repos\АнализГрафиков\АнализГрафиков\bin\Debug\BTCUSD_finam_M1_201601010000_202106260000.csv");


            #endregion
        }        

        private void e_ВертСдвиг_Click(object sender, EventArgs e)
        {
            f_Серия_СдвинутьВертикально((double)ob_ВысотаПарам.Value);
        }

        private void e_ГоризСдвиг_Click(object sender, EventArgs e)
        {
            f_Серия_СдвинутьПоВремени((double)ob_ГодПарам.Value, (double)ob_МесПарам.Value, (double)ob_ДнПарам.Value,
                (double)ob_ЧасПарам.Value, (double)ob_МинПарам.Value, (double)ob_СекПарам.Value);
        }

        private void e_График_ИзменениеМасштаба(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            f_ПерерисоватьГрафик(oldState, newState);
        }

        /// <summary>
        /// Обработчик двойного нажатия на график, для выбора определённого бара главной серии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void e_График_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ob_График.GraphPane.CurveList[0].IsVisible = false;

            bool[] Видимость = new bool[ob_График.GraphPane.CurveList.Count];
            for (int i = 2; i < ob_График.GraphPane.CurveList.Count; i++)
            {
                Видимость[i] = ob_График.GraphPane.CurveList[i].IsVisible;
                ob_График.GraphPane.CurveList[i].IsVisible = false;
            }

            int Индекс = 0;

            object БлижайщийКнажатиюОбъект = null;

            PointF ТочкаНажатия = new PointF(e.X, e.Y);

            ob_График.GraphPane.FindNearestObject(ТочкаНажатия, this.CreateGraphics(), out
            БлижайщийКнажатиюОбъект, out Индекс);

            CurveItem СерияБлижайшейТочки = null;

            ob_График.GraphPane.FindNearestPoint(ТочкаНажатия, ob_График.GraphPane.CurveList, out СерияБлижайшейТочки, out Индекс);

            for (int i = 2; i < ob_График.GraphPane.CurveList.Count; i++)
            {
                ob_График.GraphPane.CurveList[i].IsVisible = Видимость[i];
            }

            if (СерияБлижайшейТочки == null)
            {
                MessageBox.Show("No curve found");
                return;
            }
            if (Индекс == -1)
            {
                MessageBox.Show("No curve found");
                return;
            }

            double Xграфика;

            double Yграфика;

            ob_График.GraphPane.ReverseTransform(ТочкаНажатия, out Xграфика, out Yграфика);

            var ТочкиСерии = (CustomStockPointList)СерияБлижайшейТочки.Points;

            var ВыбраннаяТочка = ТочкиСерии.FirstOrDefault(x => x.Date >= Xграфика);

            if (ВыбраннаяТочка == null)
            {
                MessageBox.Show("No point found");
                return;
            }


            iВыбранныйБар = (StockPt)ВыбраннаяТочка;

            ob_ЦенаОтрытияБара.Value = (decimal)iВыбранныйБар.Open;
            ob_ЦенаМаксБара.Value = (decimal)iВыбранныйБар.High;
            ob_ЦенаМинБара.Value = (decimal)iВыбранныйБар.Low;
            ob_ЦенаЗакрытияБара.Value = (decimal)iВыбранныйБар.Close;
            ob_ОбъёмБара.Value = (decimal)iВыбранныйБар.Vol;

            //MessageBox.Show($"Data {((XDate)iВыбранныйБар.Date).DateTime.ToString()}");

            //Перемещаем визуальный указатель на этот бар
            iУказательНаГрафике.Points[0].X = iВыбранныйБар.Date;
            iУказательНаГрафике.Points[0].Y = iВыбранныйБар.High;

            ob_График.GraphPane.CurveList[0].IsVisible = true;
            ob_График.Invalidate();
        }

        private void e_НайтиАномальныеБары_Click(object sender, EventArgs e)
        {
            f_ПоискАномальныхБаровВГлавнойСерии();
        }

        /// <summary>
        /// Обработчик изменения ЛистБокса серий, "чекнутые" серии отрисовываются 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void e_ЛистБоксСерий_SelectedIndexChanged(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (ob_График.GraphPane.CurveList[e.Index] != null)
                    ob_График.GraphPane.CurveList[e.Index].IsVisible = true;
            }
            else
            {
                if (ob_График.GraphPane.CurveList[e.Index] != null)
                    ob_График.GraphPane.CurveList[e.Index].IsVisible = false;
            }
                

            ob_График.Invalidate();
        }

        /// <summary>
        /// Обработчик изменения параметров конкретного бара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void e_ПараметрыБараИзменнены_ValueChanged(object sender, EventArgs e)
        {
            var ИзмененКонтрол = (NumericUpDown)sender;

            switch (ИзмененКонтрол.Name)
            {
                case "ob_ЦенаОтрытияБара":
                    iВыбранныйБар.Open = (double)ИзмененКонтрол.Value;
                    break;
                case "ob_ЦенаМаксБара":
                    iВыбранныйБар.High = (double)ИзмененКонтрол.Value;
                    break;
                case "ob_ЦенаМинБара":
                    iВыбранныйБар.Low = (double)ИзмененКонтрол.Value;
                    break;
                case "ob_ЦенаЗакрытияБара":
                    iВыбранныйБар.Close = (double)ИзмененКонтрол.Value;
                    break;
                case "ob_ОбъёмБара":
                    iВыбранныйБар.Vol = (double)ИзмененКонтрол.Value;
                    break;
                default:
                    break;
            }
            
            ob_График.AxisChange();
            ob_График.Invalidate();
        }

        private void e_ПредАномальныйБар_Click(object sender, EventArgs e)
        {
            f_ПоказатьПредБар();
        }

        private void e_СледАномальныйБар_Click(object sender, EventArgs e)
        {
            f_ПоказатьСледБар();
        }

        private void e_ЗаменитьВыбранныйБар_Click(object sender, EventArgs e)
        {
            f_ЗаменитьВыбранныйБар();
        }

        private void e_ПоискГепов_Click(object sender, EventArgs e)
        {
            f_ПоискГеповВГлавнойСерии();
        }

        private void e_СерияВверх_Click(object sender, EventArgs e)
        {
            f_Серия_ПоднятьСериюВСписке();
        }

        private void e_СерияВниз_Click(object sender, EventArgs e)
        {
            f_Серия_ОпуститьСериюВСписке();
        }


        #region Обработчики меню

        #region Серия

        private void ЗагрузитьСериюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Выберите загружаемый файл",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv"
            };

            ob_СтатусПрограммы.Text = "Подождите, идёт загрузка серии";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                f_Серия_ЗагрузитьИзФайла(openFileDialog.FileName);
                ob_СтатусПрограммы.Text = "Загрузка завершина";
            }
            else
                ob_СтатусПрограммы.Text = "Состояние программы";
        }

        private void СохранитьСериюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob_ЛистБоксСерий.SelectedIndex < 1)
            {
                MessageBox.Show($"Выберете серию в списке");
                return;
            }

            SaveFileDialog ДиалогСохрФайла = new SaveFileDialog();

            ДиалогСохрФайла.Title = "Сохранение серии";

            var ПредложенноеИмяФайла = iСписокСерий[ob_ЛистБоксСерий.SelectedIndex].iСвечи.Label.Text.Split('|')[0];

            ДиалогСохрФайла.FileName = ПредложенноеИмяФайла.Substring(0, ПредложенноеИмяФайла.Length - 4) + "_edited.csv";

            ob_СтатусПрограммы.Text = "Подождите, идёт сохранение серии";

            if (ДиалогСохрФайла.ShowDialog() == DialogResult.OK)
            {
                f_Серия_СохранитьВФайл(ДиалогСохрФайла.FileName);
                ob_СтатусПрограммы.Text = "Сохранение завершино";
            }
            else
                ob_СтатусПрограммы.Text = "Состояние программы";
        }

        private void УдалитьСериюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Серия_Удалить();
        }

        private void НевелироватьВерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Серия_НевелироватьВертикальныйСдвиг();
        }

        private void ПроверкаКотировокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Серия_ПроверитьКотировкиСерии();
        }

        #endregion

        #region Вид

        private void ОтображатьСвечамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Серия_ОтображатьСвечами();
        }

        private void ОтображатьБарамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Серия_ОтображатьБарами();
        }

        private void ЦветПовышенияСвечToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветПовышенияСвечСерии();
        }

        private void ЦветПониженияСвечToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветПониженияСвечСерии();
        }

        private void ЦветОкантовкиСвечбаровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветОкантовкиСвечБаровСерии();
        }

        private void ЦветФонаГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветФонаГрафика();
        }

        private void ЦветОкантовкиГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветОкантовкиГрафика();
        }

        private void МаксимальноеКолвоТочекToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion





        #endregion

        private void e_ВременныеСдвиги_Поиск_Click(object sender, EventArgs e)
        {
            f_ВременныеСдвиги_Поиск();
        }

        private void e_ПредСегмент_Click(object sender, EventArgs e)
        {
            f_ВременныеСдвиги_ПредСегмент();
        }

        private void e_СледСегмент_Click(object sender, EventArgs e)
        {
            f_ВременныеСдвиги_СледСегмент();
        }

        private void e_СдвинутьСектор_Click(object sender, EventArgs e)
        {
            f_СдвинутьСегмент();
        }

        

        private void e_ПоискдвойныхБаровToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f_НайтиДвойныеБары();
        }

        private void e_УдалитьдвойныеБарыТекущегоСегмантаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_УдалитьДвойныеБарыТекущегоСегмента();
        }

        private void e_УдалитьВседвойныеБарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_УдалитьДвойныеБарыВсехСегментов();
        }

        private void e_ВыбратьНачаломТекущийБарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ФрагментБаров_ВыбратьНачалом();
        }

        private void e_ВыбратьКонцомТекущийБарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ФрагментБаров_ВыбратьКонцом();
        }

        private void e_СдвинутьФрагментПоВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ФрагментБаров_СдвинутьПоВремени();
        }

        private void e_УдалитьВсеДвойныеБарыСерииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Серия_УдалитьДвойныеБары();
        }

        private void e_НачалоФрагментаНачалоСерииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ФрагментБаров_НачалоНаНачалоСерии();
        }

        private void e_КонецФрагментаКонецСерииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ФрагментБаров_КонецНаКонецСерии();
        }

        private void e_ПоказатьНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ФрагментБаров_ПоказатьНачало();
        }

        private void e_ПоказатьКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ФрагментБаров_ПоказатьКонец();
        }

        private void e_БарыБольшеДонорской_Click(object sender, EventArgs e)
        {
            f_РасхождениеБаровСЭталоном();
        }

        private void e_КоличествоОтображаемыхБаровНаСериюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Окна.c_ОкноИзменитьПараметр.c_ОкноИзменитьПараметр Окно = new Окна.c_ОкноИзменитьПараметр.c_ОкноИзменитьПараметр(
                "Настройки отрисовки",
                "Максимальное количество отображаемых точек для одной серии",
                (decimal)iМаксОтрисовываемыхБаровНаСерию,
                0))
            {
                if (Окно.ShowDialog() == DialogResult.OK)
                    iМаксОтрисовываемыхБаровНаСерию = (int)Окно.ЗначениеПараметра;
            }
        }

        private void e_УдалитьОдинокиеБарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Серия_УдалитьОдинокиеБары();
        }

        private void e_ЗаменитьПустыеБарыБарамиДонорскойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ЗаменитьПустыеБарыВГлавнойСерии();
        }

        private void e_ПерейтиКВыбраннойДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_Серия_ПерейтиКДате();
        }

        private void e_ЗаменитьВсеАномальныеБарыБарамиДонорскойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ЗаменитьВсеАномальныеБары();
        }

        private void e_СдвинутьФрагментПоВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ФрагментБаров_СдвинутьПоВысоте();
        }
    }
}
