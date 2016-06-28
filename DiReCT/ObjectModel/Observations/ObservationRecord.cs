/**
 * Copyright (c) 2016 DRBoaST
 * 
 * Project Name:
 * 
 * 		DiReCT(Disaster Record Capture Tool)
 * 
 * File Name:
 * 
 * 		ObservationRecord.cs
 * 
 * Abstract:
 * 
 *      ObservationRecord is an abstract class which contains basic members 
 *      for data captured by time stamped, location stamped, etc. 
 *
 * 		This class can not be instantiated and can be inherited by others subclasses. 
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
using System.Device.Location;

namespace DiReCT.ObjectModel
{

    public abstract class ObservationRecord
    {
        /// <summary>
        /// This property is for accessing value of UID.
        /// The UID is a identifier of the ObservationRecord.
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        /// This Auto-property is for accessing value of timestamp.
        /// The time stamp means the date of filing a record.
        /// </summary>
        public DateTime TimeStamp { get; set; } = new DateTime();

        /// <summary>
        /// This Auto-property is for accessing value of location stamp.
        /// </summary>
        public virtual GeoCoordinate LocationStamp { get; set; } = new GeoCoordinate();

        /// <summary>
        /// This Auto-property is for accessing value of outlier.
        /// Default value is false.
        /// </summary>
        public Boolean Outlier { get; set; } = false;

        /// <summary>
        /// This Auto-property is for accessing value of possible damage reason.
        /// </summary>
        public List<string> Reasons { get; set; } = new List<string>();

        /// <summary>
        /// This Auto-property is for accessing value of record description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This Auto-property is for accessing value of recorder UID.
        /// </summary>
        public string RecorderUID { get; set; }

        /// <summary>
        /// This Auto-property is for accessing value of event UID.
        /// </summary>
        public string EventUID { get; set; }

        /// <summary>
        /// The struct structure contains video, audio and photo paths.
        /// </summary>
        public struct Multimedia
        {
            /// <summary>
            /// This dictionary stores videos' file of paths.
            /// </summary>
            public Dictionary<string, string> VideoFilePaths { get; set; }

            /// <summary>
            /// This dictionary stores the audios' file of paths.
            /// </summary>
            public Dictionary<string, string> AudioFilePaths { get; set; }

            /// <summary>
            /// This dictionary stores the photos' file of paths.
            /// </summary>
            public Dictionary<string, string> PhotoFilePaths { get; set; }
        }
    }
}

