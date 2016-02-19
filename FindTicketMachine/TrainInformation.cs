using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSearch
{
    public class TrainInformation
    {
        public string trainNo { get; set; }
        public string trainCode { get; set; }
        public string fromStationName { get; set; }
        public string toStationName { get; set; }
        public string startTime { get; set; }
        public string arriveTime { get; set; }
        public string dayDifference { get; set; }
        public string spendTime { get; set; }
        public string fromStationNo { get; set; }
        public string toStationNo { get; set; }
        public string BusinessTicket { get; set; }
        public string TopGradeTicket { get; set; }
        public string FirstClassTicket { get; set; }
        public string SecondClassTicket { get; set; }
        public string AdvancedSoftSleeperTicket { get; set; }
        public string SoftSleeperTicket { get; set; }
        public string HardSleeperTicket { get; set; }
        public string SoftSeatTicket { get; set; }
        public string HardSeatTicket { get; set; }
        public string NoneSeatTicket { get; set; }
        public string Other { get; set; }
        public List<JSON> result { get; set; }
        public TrainInformation(string str)
        {
            result = new List<JSON>();
            JSON json1 = new JSON("train_no");
            result.Add(json1);
            json1 = new JSON("station_train_code");
            result.Add(json1);
            json1 = new JSON("from_station_name");
            result.Add(json1);
            json1 = new JSON("to_station_name");
            result.Add(json1);
            json1 = new JSON("start_time");
            result.Add(json1);
            json1 = new JSON("arrive_time");
            result.Add(json1);
            json1 = new JSON("day_difference");
            result.Add(json1);
            json1 = new JSON("lishi");
            result.Add(json1);
            json1 = new JSON("from_station_no");
            result.Add(json1);
            json1 = new JSON("to_station_no");
            result.Add(json1);
            json1 = new JSON("swz_num");
            result.Add(json1);
            json1 = new JSON("tz_num");
            result.Add(json1);
            json1 = new JSON("zy_num");
            result.Add(json1);
            json1 = new JSON("ze_num");
            result.Add(json1);
            json1 = new JSON("gr_num");
            result.Add(json1);
            json1 = new JSON("rw_num");
            result.Add(json1);
            json1 = new JSON("yw_num");
            result.Add(json1);
            json1 = new JSON("rz_num");
            result.Add(json1);
            json1 = new JSON("yz_num");
            result.Add(json1);
            json1 = new JSON("wz_num");
            result.Add(json1);
            json1 = new JSON("qt_num");
            result.Add(json1);
            for (int i = 0; i < result.Count; i++)
            {
                result[i].getValue(str);
                switch (i)
                {
                    case 0: this.trainNo = result[i].Value;
                        break;
                    case 1: this.trainCode = result[i].Value;
                        break;
                    case 2: this.fromStationName = result[i].Value;
                        break;
                    case 3: this.toStationName = result[i].Value;
                        break;
                    case 4: this.startTime = result[i].Value;
                        break;
                    case 5: this.arriveTime = result[i].Value;
                        break;
                    case 6: this.dayDifference = result[i].Value;
                        break;
                    case 7: this.spendTime = result[i].Value;
                        break;
                    case 8: this.fromStationNo = result[i].Value;
                        break;
                    case 9: this.toStationNo = result[i].Value;
                        break;
                    case 10: this.BusinessTicket = result[i].Value;
                        break;
                    case 11: this.TopGradeTicket = result[i].Value;
                        break;
                    case 12: this.FirstClassTicket = result[i].Value;
                        break;
                    case 13: this.SecondClassTicket = result[i].Value;
                        break;
                    case 14: this.AdvancedSoftSleeperTicket = result[i].Value;
                        break;
                    case 15: this.SoftSleeperTicket = result[i].Value;
                        break;
                    case 16: this.HardSleeperTicket = result[i].Value;
                        break;
                    case 17: this.SoftSeatTicket = result[i].Value;
                        break;
                    case 18: this.HardSeatTicket = result[i].Value;
                        break;
                    case 19: this.NoneSeatTicket = result[i].Value;
                        break;
                    case 20: this.Other = result[i].Value;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
