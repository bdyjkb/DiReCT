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
        /// The depth of water.
        /// </summary>
        public int WaterDepth { get; set; }

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
        /// If the recorder knows how many people are affected.
        /// (Optional, will show after chooses "Yes")
        /// </summary>
        public int NumbersOfAffectedPeople { get; set; }

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
        /// If the recorder knows how many cars are affected.
        /// (Optional, will show after chooses "Yes")
        /// </summary>
        public int NumbersOfAffectedCars { get; set; }

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

        /// <summary>
        /// If the recorder knows how many houses are affected.
        /// (Optional, will show after chooses "Yes")
        /// </summary>
        public int NumbersOfAffectedHouse { get; set; }

        /// <summary>
        /// 受困原因
        /// Does the recorder know whether the reasons of  
        /// be trapped or not?
        /// Reasons of trapped.
        /// </summary>
        public enum TrappedReasons
        {
            Flooded,
            BridgeBroken,
            RoadsBlocked,
            IDoNotKnow
        }

        /// <summary>
        /// 有無災民受困
        /// Does the recorder know whether people are trapped  
        /// or not?
        /// </summary>
        public enum ArePeolpleTrapped
        {
            Yes,
            NO,
            IDoNotKnow
        }

        /// <summary>
        /// If the recorder knows how many people are trapped.
        /// (Optional, will show after chooses "Yes")
        /// </summary>
        public int NumbersOfTrappedPeople { get; set; }

        /// <summary>
        /// 受困災民種類
        /// </summary>
        public enum TypesOfTrappedPeople
        {
            Tourist,
            Passerby,
            Pedestrian,
            Resident,
            IDoNotKnow
        } 
    }
}
