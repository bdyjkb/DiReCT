using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT.ObjectModel
{
    class BackgroundInfo
    {
        /// <summary>
        /// 溪流編號 (第一次回報免填寫)
        /// </summary>
        public string RivuletCode { get; set; }

        /// <summary>
        /// 溪流名稱 (第一次回報免填寫)
        /// </summary>
        public string RivuletName { get; set; }

        /// <summary>
        /// 行政區域
        /// </summary>
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// 有無歷史災害
        /// </summary>
        public bool HasThereBeenAnyHistoricalDamages { get; set; }

        /// <summary>
        /// 歷史災害發生次數
        /// </summary>
        public int HistoricalDamageCounts { get; set; }

        /// <summary>
        /// 歷史災害發生原因
        /// </summary>
        public List<string> HistoricalReasons { get; set; }

        /// <summary>
        /// 行政單位
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 是否有災害歷史
        /// </summary>
        public bool HistoricalDamage { get; set; }
    }
}
