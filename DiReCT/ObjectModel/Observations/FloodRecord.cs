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
        /// 水災發生地點
        /// The FloodOccurArea is the location at which the flood 
        /// occured.
        /// </summary>
        public List<GeoCoordinate> FloodOccuredArea { get; set; }


        /// <summary>
        /// 水災深度
        /// The depth of flood.
        /// </summary>
        public int FloodDepth { get; set; }


        /// <summary>
        /// 水災是否有影響到人
        /// Does the recorder know whether the flood affect  
        /// people or not?
        /// </summary>
        public enum ArePeopleAffected
        {
            Yes,
            No,
            IDoNotKnow
        }


        /// <summary>
        /// 水災是否影響汽車通行
        /// Does the recorder know whether the flood affect 
        /// cars or not?
        /// </summary>
        public enum AreCarsAffected
        {
            Yes,
            No,
            IDoNotKnow
        }


        /// <summary>
        /// 水災是否影響住宅
        /// Does the recorder know  whether the flood affect any 
        /// houses or not?
        /// </summary>
        public enum AreHousesAffected
        {
            Yes,
            NO,
            IDoNotKnow
        }
    }
}
