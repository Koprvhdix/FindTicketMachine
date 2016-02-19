using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSearch
{
    public class TrainNo
    {
        public string fromStationName { get; set; }
        public string toStationName { get; set; }
        public string trainNo { get; set; }
        public string trainCode { get; set; }
        public string fromStation { get; set; }
        public string toStation { get; set; }
        public string leaveDate { get; set; }
        public List<Station> StationInformation { get; set; }
        public List<TrainNoStation> TrainNoStationList { get; set; }
        public int fromStationNo { get; set; }
        public int toStationNo { get; set; }
        public List<int> Time { get; set; }
        public List<TrainChoose> trainChoose { get; set; }
        public List<TrainChoose> ResultChoose { get; set; }
        public TrainInformation show2 { get; set; }
        public TrainInformation show1 { get; set; }
        public TrainInformation show3 { get; set; }
        public TrainNo(string trainNo, string trainCode, string fromStation, string toStation, string leaveDate, List<Station> stationInformation, string fromStationName, string toStationName)
        {
            this.fromStationName = fromStationName;
            this.toStationName = toStationName;
            this.trainNo = trainNo;
            this.trainCode = trainCode;
            this.fromStation = fromStation;
            this.toStation = toStation;
            this.leaveDate = leaveDate;
            this.StationInformation = stationInformation;
            this.TrainNoStationList = new List<TrainNoStation>();
            this.Time = new List<int>();
            this.trainChoose = new List<TrainChoose>();
            this.ResultChoose = new List<TrainChoose>();
        }

        public void getInformation()
        {
            string Url = "https://kyfw.12306.cn/otn/czxx/queryByTrainNo?train_no=" + trainNo + "&from_station_telecode=" + fromStation + "&to_station_telecode=" + toStation + "&depart_date=" + leaveDate;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
                req.Method = "GET";
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                {
                    return true;
                };
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream resst = res.GetResponseStream();
                StreamReader sr = new StreamReader(resst);
                string str = sr.ReadToEnd();

                int finalPosition = str.LastIndexOf("arrive_time");
                int position1 = 0, position2 = 1;
                string getString = "";
                TrainNoStation trainStation;
                for (int i = 1; ; i++)
                {
                    position1 = str.IndexOf("arrive_time", position2 - 1);
                    if (position2 == 1)
                    {
                        position2 = str.IndexOf("arrive_time", position1 + "arrive_time".Count());
                        getString = str.Substring(position1, position2 - position1 - 1);
                        trainStation = new TrainNoStation(getString, StationInformation, i, 0);
                        if (trainStation.stationName == fromStationName)
                        {
                            fromStationNo = i;
                        }
                        TrainNoStationList.Add(trainStation);
                    }
                    else if (position1 == finalPosition)
                    {
                        getString = str.Substring(position1, str.Count() - position1 - 1);
                        trainStation = new TrainNoStation(getString, StationInformation, i, 1);
                        if (trainStation.stationName == toStationName)
                        {
                            toStationNo = i;
                        }
                        TrainNoStationList.Add(trainStation);
                        break;
                    }
                    else
                    {
                        position2 = str.IndexOf("arrive_time", position1 + "arrive_time".Count());
                        getString = str.Substring(position1, position2 - position1 - 1);
                        trainStation = new TrainNoStation(getString, StationInformation, i);
                        if (trainStation.stationName == fromStationName)
                        {
                            fromStationNo = i;
                        }
                        else if (trainStation.stationName == toStationName)
                        {
                            toStationNo = i;
                        }
                        TrainNoStationList.Add(trainStation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请检查网络连接");
            }
        }

        public void SortTime()
        {
            int hour = 0, minute = 0, start1 = 0, start2 = 0, arrive1 = 0, arrive2 = 0;
            int time = 0;
            for (int i = 0; i < TrainNoStationList.Count() - 1; i++)
            {
                start1 = TrainNoStationList[i].start1;
                start2 = TrainNoStationList[i].start2;
                arrive1 = TrainNoStationList[i + 1].arrive1;
                arrive2 = TrainNoStationList[i + 1].arrive2;
                if (arrive2 < start2)
                {
                    minute = arrive2 + 60 - start2;
                    arrive1--;
                }
                else
                {
                    minute = arrive2 - start2;
                }
                if (arrive1 >= start1)
                    hour = arrive1 - start1;
                else
                    hour = arrive1 + 24 - start1;
                time = hour * 60 + minute;
                Time.Add(time);
            }

            TrainChoose choose;
            int sumTime = 0;
            for (int i = 0; i < fromStationNo; i++)
            {
                for (int j = toStationNo - 1; j < TrainNoStationList.Count(); j++)
                {
                    sumTime = 0;
                    for (int k = i; k < j; k++)
                    {
                        sumTime += Time[k];
                    }
                    choose = new TrainChoose(i, j, sumTime);
                    trainChoose.Add(choose);
                }
            }

            var sort = from t in trainChoose
                       orderby t.time
                       select t;

            foreach (var i in sort)
            {
                ResultChoose.Add(i);
            }
        }

        public bool FirstDeepSearchTicket(List<int> SeatCheck)
        {
            //try
            {
                for (int i = 0; i < 20 && i < ResultChoose.Count(); i++)
                {
                    string from = TrainNoStationList[ResultChoose[i].from].stationCode;
                    string to = TrainNoStationList[ResultChoose[i].to].stationCode;
                    string Url;
                    Url = "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=ADULT&queryDate=" + leaveDate + "&from_station=" + from + "&to_station=" + to;
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
                    req.Method = "GET";
                    System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                    {
                        return true;
                    };
                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                    Stream resst = res.GetResponseStream();
                    StreamReader sr = new StreamReader(resst);
                    string str = sr.ReadToEnd();

                    int site1 = 0, site2 = 1, lastSite;
                    string getString = "";
                    lastSite = str.LastIndexOf("train_no");
                    TrainInformation trainInformation;
                    for (; ; )
                    {
                        site1 = str.IndexOf("train_no", site2 - 1);
                        if (site1 == lastSite)
                        {
                            getString = str.Substring(site1, str.Count() - site1);
                            trainInformation = new TrainInformation(getString);
                            if (trainInformation.trainNo == this.trainNo)
                            {
                                if (getTicketInformation(SeatCheck, trainInformation))
                                {
                                    show1 = trainInformation;
                                    return true;
                                }
                            }
                            break;
                        }
                        else
                        {
                            site2 = str.IndexOf("train_no", site1 + 20);
                            getString = str.Substring(site1, site2 - site1 - 1);
                            trainInformation = new TrainInformation(getString);
                            if (trainInformation.trainNo == this.trainNo)
                            {
                                if (getTicketInformation(SeatCheck, trainInformation))
                                {
                                    show1 = trainInformation;
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
            //catch(Exception)
            //{
            //    MessageBox.Show("TrainNo有问题");
            //    return false;
            //}
        }

        public bool TopDeepSearchTicket(List<int> SeatCheck)
        {
            for (int i = 0; i < ResultChoose.Count(); i++)
            {
                string from = TrainNoStationList[ResultChoose[i].from].stationCode;
                string to = TrainNoStationList[ResultChoose[i].to].stationCode;
                string Url;
                Url = "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=ADULT&queryDate=" + leaveDate + "&from_station=" + from + "&to_station=" + to;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
                req.Method = "GET";
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                {
                    return true;
                };
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream resst = res.GetResponseStream();
                StreamReader sr = new StreamReader(resst);
                string str = sr.ReadToEnd();

                int site1 = 0, site2 = 1, lastSite;
                string getString = "";
                lastSite = str.LastIndexOf("train_no");
                TrainInformation trainInformation;
                for (; ; )
                {
                    site1 = str.IndexOf("train_no", site2 - 1);
                    if (site1 == lastSite)
                    {
                        getString = str.Substring(site1, str.Count() - site1);
                        trainInformation = new TrainInformation(getString);
                        if (trainInformation.trainNo == this.trainNo)
                        {
                            if (getTicketInformation(SeatCheck, trainInformation))
                            {
                                show2 = trainInformation;
                                return true;
                            }
                        }
                        break;
                    }
                    else
                    {
                        site2 = str.IndexOf("train_no", site1 + 20);
                        getString = str.Substring(site1, site2 - site1 - 1);
                        trainInformation = new TrainInformation(getString);
                        if (trainInformation.trainNo == this.trainNo)
                        {
                            if (getTicketInformation(SeatCheck, trainInformation))
                            {
                                show2 = trainInformation;
                                return true;
                            }
                            break;
                        }
                    }
                }
            }
            return false;
        }

        public bool PatchDeepSearchTicket(List<int> SeatCheck)
        {
            int i = fromStationNo;
            int j = toStationNo;
            for (; j > i; j--)
            {
                string from = TrainNoStationList[i - 1].stationCode;
                string to = TrainNoStationList[j - 1].stationCode;
                string Url;
                Url = "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=ADULT&queryDate=" + leaveDate + "&from_station=" + from + "&to_station=" + to;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
                req.Method = "GET";
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                {
                    return true;
                };
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream resst = res.GetResponseStream();
                StreamReader sr = new StreamReader(resst);
                string str = sr.ReadToEnd();

                int site1 = 0, site2 = 1, lastSite;
                string getString = "";
                lastSite = str.LastIndexOf("train_no");
                TrainInformation trainInformation;
                for (; ; )
                {
                    site1 = str.IndexOf("train_no", site2 - 1);
                    if (site1 == lastSite)
                    {
                        getString = str.Substring(site1, str.Count() - site1);
                        trainInformation = new TrainInformation(getString);
                        if (trainInformation.trainNo == this.trainNo)
                        {
                            if (getTicketInformation(SeatCheck, trainInformation))
                            {
                                show3 = trainInformation;
                                return true;
                            }
                        }
                        break;
                    }
                    else
                    {
                        site2 = str.IndexOf("train_no", site1 + 20);
                        getString = str.Substring(site1, site2 - site1 - 1);
                        trainInformation = new TrainInformation(getString);
                        if (trainInformation.trainNo == this.trainNo)
                        {
                            if (getTicketInformation(SeatCheck, trainInformation))
                            {
                                show3 = trainInformation;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool getTicketInformation(List<int> SeatCheck, TrainInformation trainInformation)
        {
            string test = "";
            int result = 0;
            for (int i = 0; i < SeatCheck.Count(); i++)
            {
                switch (SeatCheck[i])
                {
                    case 0: test = trainInformation.SecondClassTicket;
                        if (int.TryParse(test, out result))
                        {
                            return true;
                        }
                        break;
                    case 1: test = trainInformation.SoftSleeperTicket;
                        if (int.TryParse(test, out result))
                        {
                            return true;
                        }
                        break;
                    case 2: test = trainInformation.HardSleeperTicket;
                        if (int.TryParse(test, out result))
                        {
                            return true;
                        }
                        break;
                    case 3: test = trainInformation.HardSeatTicket;
                        if (int.TryParse(test, out result))
                        {
                            return true;
                        }
                        break;
                    default: test = trainInformation.NoneSeatTicket;
                        if (int.TryParse(test, out result))
                        {
                            return true;
                        }
                        break;
                }
            }
            return false;
        }
    }
}