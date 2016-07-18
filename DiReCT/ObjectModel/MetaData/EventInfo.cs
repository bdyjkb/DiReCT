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
 * 		EventInfo.cs
 *
 * Abstract:
 *
 *      EventInfo.cs is a abstract class which is the model of 
 *      observation record metadata.
 *      It contains members to store event information.
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
using System.Collections.Generic;

namespace DiReCT.ObjectModel
{
    public class EventInfo
    {
        /// <summary>
        /// This is for accessing value of UID.
        /// The UID is a identifier of the EventInfo.
        /// </summary>
        public string UID { get; set; }


        /// <summary>
        /// This is for accessing value of event name.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// This is for accessing value of event type.
        /// </summary>
        public string Type { get; set; }


        /// <summary>
        /// This SortedList data structure is for storing 
        /// the pointers to ObservationRecords.
        /// </summary>
        public Dictionary<string, ObservationRecord> ObservationList 
            = new Dictionary<string, ObservationRecord>();


        /// <summary>
        /// This SortedList data structure is for storing 
        /// the pointers to RecorderInfos.
        /// </summary>
        public Dictionary<string, RecorderInfo> RecorderList 
            = new Dictionary<string, RecorderInfo>();
    }
}
