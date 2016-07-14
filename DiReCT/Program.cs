using System;
using System.Diagnostics;
using System.Device.Location;
using System.Collections.Generic;
using System.Collections;
using DiReCT.ObjectModel;


namespace DiReCT
{
    class MainClass
    {
        /// <summary>
        /// 
        /// In this example, we use flood scenario to illustrate 
        /// how to manipulate floodRecord.
        /// 
        /// </summary>
        /// <param name="args"></param>
		public static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();

            List<int> randomList = new List<int>();

            timer.Reset();
            timer.Start();
            // Create a Event object
            EventInfo eventInfo = new EventInfo();
            eventInfo.Name = "莫拉颱風";
            eventInfo.Type = "typhoon";
            Console.WriteLine("Spending Time of creating a EventInfo object: {0} ticks ({1} msec)", timer.ElapsedTicks, timer.ElapsedMilliseconds);


            timer.Reset();
            timer.Start();
            // Create a Dictionary for 300 recorders
            Dictionary<string, RecorderInfo> RIDictionary = new Dictionary<string, RecorderInfo>();
            {
                for (int index = 0; index < 300; index++)
                {
                    RecorderInfo recorder = new RecorderInfo();

                    recorder.UID = index.ToString();
                    recorder.Name = string.Format("Recorder{0:D6}", index);
                    recorder.PhoneNumber = string.Format("0988-{0:D6}", index);

                    if (index < 150)
                    {
                        recorder.Organization = "IIS";
                    }
                    else
                    {
                        recorder.Organization = "CITI";
                    }

                    RIDictionary.Add(recorder.UID, recorder);
                }
            }
            Console.WriteLine("Spending Time of creating a RIDictionary: {0} ticks ({1} msec)", timer.ElapsedTicks, timer.ElapsedMilliseconds);


            timer.Reset();
            timer.Start();
            // Create a Dictionary for 5000000 ObservationRecords
            //Dictionary<string, ObservationRecord> ORDictionary = new Dictionary<string, ObservationRecord>();
            //{
            //    for (int index = 0; index < 50; index++)
            //    {
            //        CasualtiesRecord casualties = new CasualtiesRecord();

            //        casualties.UID = eventInfo.Type
            //            + "-" + eventInfo.Name
            //            //+ "-" + DateTime.Now.ToString("yyyyMMddHHmmss")
            //            + "-" + index;
            //        casualties.TimeStamp = DateTime.UtcNow;
            //        casualties.LocationStamp = new GeoCoordinate();

            //        casualties.DeathToll = index;
            //        casualties.Injuries = index;
            //        casualties.MissingPeople = index;

            //        // Add a record to ORDicionary
            //        ORDictionary.Add(casualties.UID, casualties);

            //        // Add a reference to some recorder
            //        RIDictionary["0"].ObservationList.Add(casualties.UID, casualties);
            //    }
            //}
            Console.WriteLine("Spending Time of creating a ORDictionary: {0} ticks ({1} msec)", timer.ElapsedTicks, timer.ElapsedMilliseconds);
            Console.WriteLine("Using Memory: {0}MB", Environment.WorkingSet / 1000000);

            var result = RIDictionary["0"].ObservationList.Count;
            Console.WriteLine(result);

            //timer.Reset();
            //timer.Start();
            //// Find UID in ORDictionary
            //string findUID = eventInfo.Type + "-" + eventInfo.Name + "-" + "4560";

            //ObservationRecord result = ORs[findUID];
            //Console.WriteLine("Spending Time of searching a UID: {0} ticks ({1} msec)", timer.ElapsedTicks, timer.ElapsedMilliseconds);
            Console.ReadLine();
        }



    }
}
