using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АнализГрафиков.c_СписокСекторов
{
    public class c_СписокСегментов : List<c_Сегмент.c_Сегмент>
    {
        public c_СписокСегментов(c_Серия.c_Серия _СерияГлавн, c_Серия.c_Серия _СерияДонор)
        {
            iсерияСектораГлавн = _СерияГлавн;
            iсерияСектораДонор = _СерияДонор;
        }

        private c_Серия.c_Серия iсерияСектораГлавн;
        private c_Серия.c_Серия iсерияСектораДонор;

        #region Prop

        public c_Серия.c_Серия iСерияСектораГлавн { get => iсерияСектораГлавн; }

        public c_Серия.c_Серия iСерияСектораДонор { get => iсерияСектораДонор; }

        #endregion
    }
}
