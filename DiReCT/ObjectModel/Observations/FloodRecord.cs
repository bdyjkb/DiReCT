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
 * 		Flood.cs
 *
 * Abstract:
 *
 * 		FloodRecord is a subclass inherited ObservationRecord.    
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
    class FloodRecord : ObservationRecord
    {
        /// <summary>
        /// 查詢及回覆對象
        /// </summary>
        public DateTime ReplyTime { get; set; }

        /// <summary>
        /// 查詢及回覆對象
        /// </summary>
        public string ReplierOrganization { get; set; }

        /// <summary>
        /// 查詢及回覆對象
        /// </summary>
        public string ReplierName { get; set; }

        // <summary>
        /// 淹水發生地點
        /// </summary>
        public string FloodAddress { get; set; }

        /// <summary>
        /// 淹水發生時間
        /// </summary>
        public DateTime FloodOccurTime { get; set; }

        /// <summary>
        /// 淹水事件情形
        /// </summary>
        public struct FloodSituation
        {
            /// <summary>
            /// 淹水情形-長度
            /// </summary>
            public int FloodLength { get; set; }

            /// <summary>
            /// 淹水情形-寬度
            /// </summary>
            public int FloodWidth { get; set; }

            /// <summary>
            /// 淹水情形-深度
            /// </summary>
            public int FloodDepth { get; set; }
        }

        /// <summary>
        /// 是否影響人車通行
        public bool IsThereAnyCarOrPeopleAffected { get; set; }

        /// <summary>
        /// 是否影響住宅
        /// </summary>
        public bool IsThereAnyHouseAffected { get; set; }

        /// <summary>
        /// This Auto-property is for accessing value of flood occur area.
        /// </summary>
        public List<GeoCoordinate> FloodOccurArea { get; set; }

        /// <summary>
        /// This method can get the real-time rainfall from CWB.
        /// </summary>
        public double GetRealTimeRainfall() { return 0; }

        /// <summary>
        /// This method can get the rain pH value from CWB.
        /// </summary>
        public double GetRainpHValue { get; set; }

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
        /// 防治工程
        /// </summary>
        public List<int> ProtectionWorks { get; set; }

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
