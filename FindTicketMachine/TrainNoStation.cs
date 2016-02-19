using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSearch
{
    public class TrainNoStation
    {
        public string stationName { get; set; }
        public string stationCode { get; set; }
        public int stationNo { get; set; }
        public string arriveTime { get; set; }
        public string startTime { get; set; }
        public int arrive1 { get; set; }
        public int arrive2 { get; set; }
        public int start1 { get; set; }
        public int start2 { get; set; }
        public TrainNoStation(string str, List<Station> StationInformation, int count1)
        {
            this.stationNo = count1;
            List<JSON> JsonList = new List<JSON>();
            JSON json1 = new JSON("arrive_time");
            JsonList.Add(json1);
            json1 = new JSON("station_name");
            JsonList.Add(json1);
            json1 = new JSON("start_time");
            JsonList.Add(json1);
            int position1 = 0;
            string FirstNumber = "", SecondeNumber = "";
            for (int i = 0; i < JsonList.Count(); i++)
            {
                JsonList[i].getValue(str);
                switch (i)
                {
                    case 0: this.arriveTime = JsonList[i].Value;
                        position1 = arriveTime.IndexOf(':');
                        FirstNumber = arriveTime.Substring(0, position1);
                        SecondeNumber = arriveTime.Substring(position1 + 1, arriveTime.Length - position1 - 1);
                        arrive1 = Convert.ToInt32(FirstNumber);
                        arrive2 = Convert.ToInt32(SecondeNumber);
                        break;
                    case 1: this.stationName = JsonList[i].Value;
                        for (int j = 0; j < StationInformation.Count(); j++)
                        {
                            if (StationInformation[j].chinese == stationName)
                            {
                                this.stationCode = StationInformation[j].code;
                                break;
                            }
                        }
                        break;
                    case 2: this.startTime = JsonList[i].Value;
                        position1 = startTime.IndexOf(':');
                        FirstNumber = startTime.Substring(0, position1);
                        SecondeNumber = startTime.Substring(position1 + 1, startTime.Length - position1 - 1);
                        start1 = Convert.ToInt32(FirstNumber);
                        start2 = Convert.ToInt32(SecondeNumber);
                        break;
                    default:
                        break;
                }
            }
        }
        public TrainNoStation(string str, List<Station> StationInformation, int count1, int a)
        {
            this.stationNo = count1;
            List<JSON> JsonList = new List<JSON>();
            JSON json1 = new JSON("arrive_time");
            JsonList.Add(json1);
            json1 = new JSON("station_name");
            JsonList.Add(json1);
            json1 = new JSON("start_time");
            JsonList.Add(json1);
            int position1 = 0;
            string FirstNumber = "", SecondeNumber = "";
            for (int i = 0; i < JsonList.Count(); i++)
            {
                JsonList[i].getValue(str);
                switch (i)
                {
                    case 0: this.arriveTime = JsonList[i].Value;
                        if (a != 0)
                        {
                            position1 = arriveTime.IndexOf(':');
                            FirstNumber = arriveTime.Substring(0, position1);
                            SecondeNumber = arriveTime.Substring(position1 + 1, arriveTime.Length - position1 - 1);
                            arrive1 = Convert.ToInt32(FirstNumber);
                            arrive2 = Convert.ToInt32(SecondeNumber);
                        }
                        break;
                    case 1: this.stationName = JsonList[i].Value;
                        for (int j = 0; j < StationInformation.Count(); j++)
                        {
                            if (StationInformation[j].chinese == stationName)
                            {
                                this.stationCode = StationInformation[j].code;
                                break;
                            }
                        }
                        break;
                    case 2: this.startTime = JsonList[i].Value;
                        if (a == 0)
                        {
                            position1 = startTime.IndexOf(':');
                            FirstNumber = startTime.Substring(0, position1);
                            SecondeNumber = startTime.Substring(position1 + 1, startTime.Length - position1 - 1);
                            start1 = Convert.ToInt32(FirstNumber);
                            start2 = Convert.ToInt32(SecondeNumber);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}