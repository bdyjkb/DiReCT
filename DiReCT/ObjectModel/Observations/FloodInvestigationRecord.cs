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
 * 		FloodInvestigationRecord.cs
 *
 * Abstract:
 *
 *      FloodInvestigationRecord is a subclass 
 *      inherited from ObservationRecord.
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


namespace DiReCT.ObjectModel
{
    class FloodInvestigationRecord : ObservationRecord
    {
        /// <summary>
        /// 淹水發生單位
        /// </summary>
        public string Area { get; set; }

        // <summary>
        /// 淹水發生地點
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// 淹水發生時間
        /// </summary>
        public DateTime FloodOccurTime { get; set; }

        /// <summary>
        /// 淹水情形
        /// </summary>
        public int FloodLength { get; set; }

        /// <summary>
        /// 淹水情形
        /// </summary>
        public int FloodWidth { get; set; }

        /// <summary>
        /// 淹水情形
        /// </summary>
        public int FloodDeep { get; set; }


        /// <summary>
        /// 影響人車通行
        public bool IsThereAnyCarPeopleInfluence { get; set; }

        /// <summary>
        /// 住宅淹水
        /// </summary>
        public bool IsThereAnyHouseInfluence { get; set; }



    }
}
