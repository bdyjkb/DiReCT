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
        /// 淹水發生時間
        /// The time stamp means the time instant at which the flood
        /// occured.
        /// </summary>
        public DateTime FloodTimeStamp { get; set; } = new DateTime();



        /// <summary>
        /// This Auto-property is for accessing value of flood occur area.
        /// </summary>
        public List<GeoCoordinate> FloodOccurArea { get; set; }


        /// <summary>
        /// 淹水發生地點
        /// Flood location stamp is the location at which the flood 
        /// occured.
        /// </summary>
        public virtual GeoCoordinate FloodLocationStamp { get; set; }
               = new GeoCoordinate();

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
        public enum IsThereAnyCarOrPeopleAffected
        {
            Yes,
            No,
            IDontKnow
        }
        /// <summary>
        /// 是否影響住宅
        /// </summary>
        public enum IsThereAnyHouseAffected
        {
            Yes,
            NO,
            IDontKnow
        }

    }
}
