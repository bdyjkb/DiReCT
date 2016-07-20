using System;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiReCT.ObjectModel.Observations
{
    class UploadObservation
    {
        public static void UploadJsonToServer(ObservationRecord record)
        {
            // Convert object to json
            string json = JsonConvert.SerializeObject(record);

            string localPathname = "..\\..\\..\\data\\";
            string filename = record.UID + ".json";
            string remotePathname = "http://140.109.17.111:9000/Upload.aspx";

            using (StreamWriter outputFile = new StreamWriter(localPathname + filename))
            {
                outputFile.WriteLine(json);
            }

            WebClient client = new WebClient();
            byte[] responseArray = client.UploadFile(remotePathname, localPathname + filename);

        }
    }

}
