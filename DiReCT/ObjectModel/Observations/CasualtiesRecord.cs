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
 * 		CasualtiesRecord.cs
 *
 * Abstract:
 *
 * 		CasualtiesRecord is a subclass inherited from ObservationRecord.
 *      It provides members for data captured such as death toll, injuries, etc.
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

namespace DiReCT.ObjectModel
{
    public class CasualtiesRecord
    {
        /// <summary>
        /// This Auto-property is for accessing number of death toll.
        /// </summary>
        public int DeathToll { get; set; }

        /// <summary>
        /// This Auto-property is for accessing number of injuries.
        /// </summary>
        public int Injuries { get; set; }

        /// <summary>
        /// This Auto-property is for accessing number of missing people.
        /// </summary>
        public int MissingPeople { get; set; }


        
    }
}
