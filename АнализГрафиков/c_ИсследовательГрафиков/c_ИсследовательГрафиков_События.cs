using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            iАномальныеТочки = new CustomStockPointList();

            iАномальныеТочки_Время = new CustomStockPointList();

            iАномальныеТочки_Разрыв = new CustomStockPointList();

            iИндексТекущейАномальнойТочки = -1;

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

            //Добавляем в листобс для возможности отключить его отрисовку и чтоб не ломалась работа с индексами всей программы
            ob_ЛистБоксСерий.Items.Add(iУказательНаГрафике.Label.Text, true);

            #region Инициализация внешних параметров графика

            //Для удобства инициализации
            var График = ob_График.GraphPane;

            //Название графика
            График.Title.Text = "Исследование графиков";

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
            График.XAxis.Scale.FormatAuto = false;

            График.XAxis.Scale.MajorUnit = DateUnit.Day;
            График.XAxis.Scale.MajorStep = 1;


            #endregion
        }

        private void e_УдалитьВыбрСерию_Click(object sender, EventArgs e)
        {
            f_УдалитьВыбранСерию();
        }

        private void e_ВертСдвиг_Click(object sender, EventArgs e)
        {
            f_СдвинутьСериюВерт((double)ob_ВысотаПарам.Value);
        }

        private void e_ГоризСдвиг_Click(object sender, EventArgs e)
        {
            f_СдвинутьСериюГориз((double)ob_ГодПарам.Value, (double)ob_МесПарам.Value, (double)ob_ДнПарам.Value,
                (double)ob_ЧасПарам.Value, (double)ob_МинПарам.Value, (double)ob_СекПарам.Value);
        }

        private void e_СохранитьСерию_Click(object sender, EventArgs e)
        {
            SaveFileDialog ДиалогСохрФайла = new SaveFileDialog();

            ДиалогСохрФайла.Title = "Сохранение серии";

            ДиалогСохрФайла.ShowDialog();

            ob_СтатусПрограммы.Text = "Подождите, идёт сохранение серии";

            if (ДиалогСохрФайла.FileName != "")
            {
                f_СохрСериюВФайл(ДиалогСохрФайла.FileName);
                ob_СтатусПрограммы.Text = "Сохранение завершино";
            }
            else
                ob_СтатусПрограммы.Text = "Состояние программы";
        }

        private void e_ЗагрузитьСерию_Click(object sender, EventArgs e)
        {
            OpenFileDialog ДиалогВыбораФайла = new OpenFileDialog
            {
                Title = "Выберите загружаемый файл",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv"
            };

            ob_СтатусПрограммы.Text = "Подождите, идёт загрузка серии";

            if (ДиалогВыбораФайла.ShowDialog() == DialogResult.OK)
            {
                f_ЗагрузитьСериюИзФайла(ДиалогВыбораФайла.FileName);
                ob_СтатусПрограммы.Text = "Загрузка завершина";
            }
            else
                ob_СтатусПрограммы.Text = "Состояние программы";
        }

        private void e_График_ИзменениеМасштаба(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            f_ПерерисоватьГрафик(newState);
        }

        private void e_СвечиВБары_Click(object sender, EventArgs e)
        {
            f_ОтображатьБарами();
        }

        private void e_БарыВСвечи_Click(object sender, EventArgs e)
        {
            f_ОтображатьСвечами();
        }

        /// <summary>
        /// Обработчик двойного нажатия на график, для выбора определённого бара главной серии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void e_График_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ob_График.GraphPane.CurveList[0].IsVisible = false;

            int Индекс = 0;

            object БлижайщийКнажатиюОбъект = null;

            PointF ТочкаНажатия = new PointF(e.X, e.Y);

            ob_График.GraphPane.FindNearestObject(ТочкаНажатия, this.CreateGraphics(), out
            БлижайщийКнажатиюОбъект, out Индекс);

            CurveItem СерияБлижайшейТочки = null;

            ob_График.GraphPane.FindNearestPoint(ТочкаНажатия, ob_График.GraphPane.CurveList, out СерияБлижайшейТочки, out Индекс);

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

            //Перемещаем визуальный указатель на этот бар
            iУказательНаГрафике.Points[0].X = iВыбранныйБар.Date;
            iУказательНаГрафике.Points[0].Y = iВыбранныйБар.High;

            ob_График.GraphPane.CurveList[0].IsVisible = true;
            ob_График.Invalidate();
        }

        private void e_НайтиАномальныеБары_Click(object sender, EventArgs e)
        {
            f_ПоискАномальныхБаров();
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

        private void e_УдалитьОдинокиеБары_Click(object sender, EventArgs e)
        {
            f_УдалитьОдинокиеБарыВыбраннойСерии(5);
        }

        private void e_ЗаменитьВсеПустыеБары_Click(object sender, EventArgs e)
        {
            f_СкопироватьПустыеБары();
        }

        private void e_ПоискГепов_Click(object sender, EventArgs e)
        {
            f_НайтиГепы();
        }

        private void e_ЦветФонаГрафика_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветФонаГрафика();
        }

        private void e_ЦветОкантовкиГрафика_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветОкантовкиГрафика();
        }

        private void e_ЦветПовышения_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветПовышенияСвечСерии();
        }

        private void e_ЦветПонижения_Click(object sender, EventArgs e)
        {
            f_Палитра_ЦветПониженияСвечСерии();
        }

        private void e_СерияВверх_Click(object sender, EventArgs e)
        {
            f_ПоднятьСериюВСписке();
        }

        private void e_СерияВниз_Click(object sender, EventArgs e)
        {
            f_ОпуститьСериюВСписке();
        }


        #region Обработчики меню

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
                f_ЗагрузитьСериюИзФайла(openFileDialog.FileName);
                ob_СтатусПрограммы.Text = "Загрузка завершина";
            }
            else
                ob_СтатусПрограммы.Text = "Состояние программы";
        }

        private void СохранитьСериюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "Сохранение серии";

            saveFileDialog1.ShowDialog();

            ob_СтатусПрограммы.Text = "Подождите, идёт сохранение серии";

            if (saveFileDialog1.FileName != "")
            {
                f_СохрСериюВФайл(saveFileDialog1.FileName);
                ob_СтатусПрограммы.Text = "Сохранение завершино";
            }
            else
                ob_СтатусПрограммы.Text = "Состояние программы";
        }

        private void УдалитьСериюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_УдалитьВыбранСерию();
        }

        private void ОтображатьСвечамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ОтображатьСвечами();
        }

        private void ОтображатьБарамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ОтображатьБарами();
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
    }
}
