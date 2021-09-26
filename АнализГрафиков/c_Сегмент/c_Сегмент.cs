using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace АнализГрафиков.c_Сегмент
{
    public class c_Сегмент
    {
        public c_Сегмент()
        {
            iбарыСегмента = new c_ЛистТочек.CustomStockPointList();

            iДельтаЦеныОткрытияСегмента = 0d;
            iСредняяВысотаБаровСегмента = 0d;

            iСдвигПоДате = new double[6];
        }
        private c_ЛистТочек.CustomStockPointList iбарыСегмента;

        public double iДельтаЦеныОткрытияСегмента;
        public double iСредняяВысотаБаровСегмента;

        public double[] iСдвигПоДате;



        public c_ЛистТочек.CustomStockPointList iБарыСегмента { get => iбарыСегмента; }

        public bool ЕстьЛиСдвиг { 
            get
            {
                for (int i = 0; i < iСдвигПоДате.Length; i++)
                {
                    if (iСдвигПоДате[i] == 0d)
                        return true;
                }

                return false;
            }
        }

        public bool СмёщёнВлево
        {
            get
            {
                for (int i = 0; i < iСдвигПоДате.Length; i++)
                {
                    if (iСдвигПоДате[i] < 0d)
                        return true;
                }

                return false;
            }
        }
    }
}
