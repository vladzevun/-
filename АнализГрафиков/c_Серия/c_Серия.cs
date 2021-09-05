using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using АнализГрафиков.c_ЛистТочек;

namespace АнализГрафиков.c_Серия
{
    public partial class c_Серия
    {
        public c_Серия()
        {
            iточкиСерии = new CustomStockPointList();

            iсдвигДата = new double[6];
            iСдвигВысота = 0d;

            iсвечи = new JapaneseCandleStickItem("Имя серии", iточкиСерии);
            iсвечи.Stick.FallingFill.Color = Color.Red;
            iсвечи.Stick.RisingFill.Color = Color.Green;

            iбары = new OHLCBarItem("Имя серии", iточкиСерии, Color.Black);
        }

        public c_Серия(CustomStockPointList _листТочек, string _имяСерии = "Имя серии не указано")
        {
            iточкиСерии = _листТочек;

            iсдвигДата = new double[6];
            iСдвигВысота = 0d;

            iсвечи = new JapaneseCandleStickItem(_имяСерии, iточкиСерии);
            iсвечи.Stick.FallingFill.Color = Color.Red;
            iсвечи.Stick.RisingFill.Color = Color.Green;

            iбары = new OHLCBarItem(_имяСерии, iточкиСерии, Color.Black);
        }

        //Здесь храниться все точки серии: 
        private CustomStockPointList iточкиСерии;

        //В листах храню сдвиг серии по времени
        //[0] - год
        //[1] - мес
        //[2] - ден
        //[3] - час
        //[4] - мин
        //[5] - сек
        private double[] iсдвигДата;
        private double iсдвигВысота;

        private JapaneseCandleStickItem iсвечи;
        private OHLCBarItem iбары;

        private int iцифрПослеЗапятой;








        #region property

        public int Count
        {
            get
            {
                return iточкиСерии.Count();
            }
        }

        //TODO: тест приватный сет
        public CustomStockPointList iТочкиСерии { get => iточкиСерии; set => iточкиСерии = value; }

        public double iСдвигВысота { get => iсдвигВысота; set => iсдвигВысота = value; }

        public double[] iСдвигДата { get => iсдвигДата; set => iсдвигДата = value; }

        public JapaneseCandleStickItem iСвечи { get => iсвечи; set => iсвечи = value; }

        public OHLCBarItem iБары { get => iбары; set => iбары = value; }

        public int iЦифрПослеЗапятой { get => iцифрПослеЗапятой; set => iцифрПослеЗапятой = value; }
        #endregion

        #region F_

        #endregion

        #region FP

        #endregion
    }

}

