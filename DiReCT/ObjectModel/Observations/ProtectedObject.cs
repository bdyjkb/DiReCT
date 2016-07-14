using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace DiReCT.ObjectModel.Observations
{
    class ProtectedObject
    {

        /// <summary>
        /// 有無土石堆積
        /// Whether debris fan deposit or not.
        /// </summary>
        public bool IsDebrisFanDeposited { get; set; }

        /// <summary>
        /// 有無崩塌
        /// Whether hillslope collapse or not.
        /// </summary>
        public bool IsHillslopeCollapsed { get; set; }

        /// <summary>
        /// 有無保全對象
        /// Whether the objects are protected or not.
        /// </summary>
        public bool AreObjectsProtected { get; set; }

        /// <summary>
        /// 保全對象類型
        /// What type is the target?
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// 保全對象編號
        /// What number is the target?
        /// </summary>
        public string TargetNumber { get; set; }

        /// <summary>
        /// 保全對象地址
        /// What address is the target?
        /// </summary>
        public string TargetAddress { get; set; }

        public struct PreventiveWorks
        {
            /// <summary>
            /// 防治工程類型
            /// Type of the preventive work.
            /// </summary>
            public List<string> PreventiveWorkTypes { get; set; }

            /// <summary>
            /// 防治工程編號
            /// Number of the preventive work.
            /// </summary>
            public List<int> PreventiveWorkNumbers { get; set; }

            /// <summary>
            /// 防治工程地點
            /// Location of the preventive work.
            /// </summary>
            public List<GeoCoordinate> PreventiveWorksLocations { get; set; }

            /// <summary>
            /// 防治工程照片 
            /// Photos of the preventive work.
            /// </summary>
            public Dictionary<string, string> PreventiveWorkPhotos { get; set; }

            /// <summary>
            /// 防治工程評估
            /// Evaluate the preventive work.
            /// </summary>
            public int PreventiveWorkEvaluation { get; set; }

            /// <summary>
            /// 防治工程評估類型
            /// Types of the preventive work.
            /// </summary>
            enum PreventiveWorkEvaluationTypes
            {
                BelowAverage,
                Average,
                VeryGood,
                Excellent
            }
        }

        public struct WarningSigns
        {
            /// <summary>
            /// 警告標誌地點
            /// Locations of the warning sign.
            /// </summary>
            public List<GeoCoordinate> WarningSignLocations { get; set; }

            /// <summary>
            /// 警告標誌編號
            /// Numbers of the warning sign.
            /// </summary>
            public List<string> WarningSignNumbers { get; set; }

            /// <summary>
            /// 警告標誌照片
            /// Photos of the warning sign.
            /// </summary>
            public Dictionary<string, string> WarningSignPhotos { get; set; }

            /// <summary>
            /// 警告標誌描述
            /// Descriptions of the warning sign.
            /// </summary>
            public List<string> WarningSignDescriptions { get; set; }
        }

        public struct DangerousSettlements
        {
            /// <summary>
            /// 有無危險聚落 (住戶大於5戶)
            /// Does the recorder know whether have dangerous settlements?
            /// More than five residents. 
            /// </summary>
            public enum AreDangerousSettlements
            {
                Yes,
                No,
                IDontKnow
            }

            /// <summary>
            /// 危險聚落評估建議
            /// Suggestions for dangerous settlements. 
            /// </summary>
            enum DangerousSettlementSuggestionTypes
            {
                None,
                Move,
                StengthenManagement,
                TemporaryShelter,
                NoAction
            }

            /// <summary>
            /// 危險聚落照片 <照片編號>
            /// The number of dangerous settlement photos.
            /// </summary>
            public Dictionary<string, string> DangerousSettlementPhotoNumbers
            { get; set; }


            /// <summary>
            /// 危險聚落照片 (說明)
            /// Descriptions and suggestions for dangerous settlements.
            /// </summary>
            public List<string> DangerousSettlementSuggestion { get; set; }

            /// <summary>
            /// 危險聚落照地點
            /// Locations of the dangerous settlements.
            /// </summary>
            public List<GeoCoordinate> DangerousSettlementLocations { get; set; }
        }
    }
}
