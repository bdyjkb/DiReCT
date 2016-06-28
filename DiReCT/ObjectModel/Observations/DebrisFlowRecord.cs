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
 * 		DebrisFlowRecord.cs
 *
 * Abstract:
 *
 * 		DebrisFlowRecord is a subclass inherited ObservationRecord.     
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
using System.Device.Location;

namespace DiReCT.ObjectModel.Observations
{
    class DebrisFlowRecord : ObservationRecord
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

        /// <summary>
        /// 行政單位
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 是否有災害歷史
        /// </summary>
        public bool HistoricalDamage { get; set; }

        /// <summary>
        /// 集水區
        /// </summary>
        public float CatchmentArea { get; set; }

        /// <summary>
        /// 發生區上游坡度
        /// </summary>
        public int SlopeOfUpperStream { get; set; }

        /// <summary>
        /// 集水區崩塌率       
        /// /// </summary>
        public int CollapseRateOfCatchmentArea { get; set; }

        /// <summary>
        /// 土石粒徑
        /// </summary>
        public int RockyParticleSize { get; set; }

        /// <summary>
        /// 主要植生生長狀況
        /// </summary>
        enum VegetationType
        {
            None,
            Meadow,
            Plantation,
            NaturalForest
        }

        /// <summary>
        /// 崩塌規模
        /// </summary>
        enum ScaleCollapse
        {
            None,
            Small,
            Large
        }

        /// <summary>
        /// 溪流災害類型
        /// </summary>
        enum RivuletDamageType
        {
            SoilErosion,
            DebrisSlide,
            ShallowSlide,
            Other
        }

        /// <summary>
        /// 發生原因
        /// </summary>
        enum PossibleReasons
        {
            Typhoon,
            HeavyRainfall,
            Other
        }

        /// <summary>
        /// 保全對象類型
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// 保全對象編號
        /// </summary>
        public string TargetCode { get; set; }

        /// <summary>
        /// 保全對象地址
        /// </summary>
        public string TargetAddress { get; set; }

        /// <summary>
        /// 防治工程編號
        /// </summary>
        public List<int> ProtectionWorkCodes { get; set; }

        /// <summary>
        /// 防治工程地點
        /// </summary>
        public List<GeoCoordinate> ProtectionWorksLocations { get; set; }

        /// <summary>
        /// 防治工程照片 
        /// </summary>
        public Dictionary<string, string> ProtectionWorksPhotos { get; set; }

        /// <summary>
        /// 現場防治工程評估
        /// </summary>
        public int RegulationProjectEvaluation { get; set; }

        /// <summary>
        /// 現場防治工程評估類型
        /// </summary>
        enum RegulationProjectEvaluationTypes
        {
            Bad,
            OK,
            Good,
            Excellent
        }

        /// <summary>
        /// 警告標誌地點
        /// </summary>
        public List<GeoCoordinate> WarningSignLocations { get; set; }

        /// <summary>
        /// 警告標誌編號
        /// </summary>
        public List<string> WarningSignCodes { get; set; }

        /// <summary>
        /// 警告標誌照片
        /// </summary>
        public Dictionary<string, string> WarningSignPhotos { get; set; }

        /// <summary>
        /// 警告標誌描述
        /// </summary>
        public List<string> WarningSignDescriptions { get; set; }

        /// <summary>
        /// 有無危險聚落
        /// </summary>
        public bool HasDangerousSettlement { get; set; }

        /// <summary>
        /// 危險聚落評估
        /// </summary>
        public int DangerousSettlementSuggestion { get; set; }

        /// <summary>
        /// 危險聚落評估類型
        /// </summary>
        enum DangerousSettlementSuggestionTypes
        {
            None,
            NeedToMove,
            Monitor,
            NeedToTakeRefuge,
            NoNeedToTakeCare
        }

        /// <summary>
        /// 危險聚落照片 <照片編號,照片編號>
        /// </summary>
        public Dictionary<string, string> DangerousSettlementPhotos { get; set; }

        /// <summary>
        /// 危險聚落照地點
        /// </summary>
        public List<GeoCoordinate> DangerousSettlementLocations { get; set; }
    }
}
