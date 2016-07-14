/**
 * Copyright (c) 2016 DRBoaST
 * 
 * Project Name:
 * 
 * 		DiReCT(Disaster Record Capture Tool)
 * 
 * File Name:
 * 
 * 		SOP.cs
 * 
 * Abstract:
 * 
 *      StandardOperatingProcedures is an abstract class which contains basic members.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT.StandardOperatingProcedures
{
    public abstract class StandardOperatingProcedures
    {
        // This method contains Timer component. 
        private void InitializeTimer() { }
        
        // This method can alert user to capture a new record.
        private void Alert() { }

    }
}
