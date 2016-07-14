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
 * 		RecorderInfo.cs
 *
 * Abstract:
 *
 *      RecorderInfo class is the model of observation record metadata.
 *      It contains members to store recorder information.
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
    public class RecorderInfo
    {

        /// <summary>
        /// The UID is the unique identifier of the EventInfo.
        /// </summary>
        public string UID { get; set; }


        /// <summary>
        /// This is for accessing value of recorder name.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// This is for accessing value of recorder organization.
        /// </summary>
        public string Organization { get; set; }


        /// <summary>
        /// This is for accessing value of recorder phone number.
        /// </summary>
        public string PhoneNumber { get; set; }


        /// <summary>
        /// This is for accessing value of recorder e-mail.
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// This SortedList data structure is for storing 
        /// the pointers to ObservationRecords.
        /// </summary>
        public Dictionary<string, ObservationRecord> ObservationList
            = new Dictionary<string, ObservationRecord>();


        /// <summary>
        /// This SortedList data structure is for storing 
        /// the pointers to EventInfos.
        /// /// </summary>
        public Dictionary<string, EventInfo> EventList
            = new Dictionary<string, EventInfo>();


    }
}
