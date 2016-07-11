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
 * 		FormsGenerator.cs
 *
 * Abstract:
 *
 *      FormsGenerator.cs can generate the form in each disaster type.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace DiReCT.ObjectModel
{
    class FormsGenerator
    {
        // To do.
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
        /// 現場防治工程類型
        /// </summary>
        public List<string> ProtectionWorks { get; set; }

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
