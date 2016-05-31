﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT.ObjectModel
{
    public class DeviceInfo
    {
        //
        // This Auto-property is a device model of the  ObservationRecord.
        //
        public string DeviceModel { get; set; }


        //
        // This Auto-property is a device IMEI code of the  ObservationRecord.
        //
        public string DeviceIMEI { get; set; }


        //
        // This Auto-property is a device Serial Number of the  ObservationRecord.
        //
        public string DeviceSerialNumber { get; set; }

    }
}
