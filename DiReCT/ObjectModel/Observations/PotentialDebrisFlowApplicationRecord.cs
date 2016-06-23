/**
 * Copyright (c) 2016 DRBoaST
 *
 * Project Name:
 *
 * 		DiReCT(Disaster Record Capture Tool)
 *
 * Version:
 *
 * 		1.0
 *
 * File Name:
 *
 * 		PotentialDebrisFlowApplicationRecord.cs
 *
 * Abstract:
 *
 *      PotentialDebrisFlowApplicationRecord.cs is a subclass 
 *      inherited from ObservationRecord.
 * 		
 *
 * Authors:
 *
 * 		Johnson Su, johnsonsu@iis.sinica.edu.tw
 *      Jeff Chen, jeff@iis.sinica.edu.tw
 *
 * License:
 *
 * 		GPL 3.0 This file is subject to the terms and conditions defined
 * 		in file 'COPYING.txt', which is part of this source code package.
 * 
 */

using System;
using System.Collections.Generic;

namespace DiReCT.ObjectModel
{
    class PotentialDebrisFlowApplicationRecord : ObservationRecord
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
        /// 災害現場是否為溪流
        /// </summary>
        public bool IsTheDebrisFlowOnRivulet { get; set; }

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
        /// 土石流發生時間
        /// </summary>
        public DateTime DebrisFlowOccurTime { get; set; }

        /// <summary>
        /// 有無土石堆積
        /// </summary>
        public bool IsThereAnyDebrisFanDeposit { get; set; }
        
        /// <summary>
        /// 有無崩塌
        /// </summary>
        public bool IsHillslopeCollapsed { get; set; }

        /// <summary>
        /// 有無保全對象
        /// </summary>
        public bool IsThereAnyProtectedObjects { get; set; }

        /// <summary>
        /// 現場防治工程類型
        /// </summary>
        public List<string> ProtectionWorks { get; set; }


    }
}
