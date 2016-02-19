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
    public class Search
    {
        public string fromStation { get; set; }
        public string fromStationName { get; set; }
        public string toStation { get; set; }
        public string toStationName { get; set; }
        public string leaveDate { get; set; }
        public List<TrainNo> trainCode { get; set; }
        public List<Station> StationInformation { get; set; }
        public List<TrainInformation> show { get; set; }
        public List<TrainChoose> GetAnother { get; set; }

        public Search(string fromStation, string toStation, string fromStationName, string toStationName, string leaveDate, List<Station> StationInformation)
        {
            this.fromStation = fromStation;
            this.toStation = toStation;
            this.leaveDate = leaveDate;
            this.StationInformation = StationInformation;
            this.trainCode = new List<TrainNo>();
            this.show = new List<TrainInformation>();
            this.fromStationName = fromStationName;
            this.toStationName = toStationName;
            this.GetAnother = new List<TrainChoose>();
        }

        public void NormalSearch()
        {
            try
            {
                string Url;
                Url = "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=ADULT&queryDate=" + leaveDate + "&from_station=" + fromStation + "&to_station=" + toStation;
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
                try
                {
                    lastSite = str.LastIndexOf("train_no");
                    TrainInformation trainInformation;
                    for (; ; )
                    {
                        site1 = str.IndexOf("train_no", site2 - 1);
                        if (site1 == lastSite)
                        {
                            getString = str.Substring(site1, str.Count() - site1);
                            trainInformation = new TrainInformation(getString);
                            show.Add(trainInformation);
                            trainCode.Add(new TrainNo(trainInformation.trainNo, trainInformation.trainCode, fromStation, toStation, leaveDate, StationInformation, trainInformation.fromStationName, trainInformation.toStationName));
                            break;
                        }
                        else
                        {
                            site2 = str.IndexOf("train_no", site1 + 20);
                            getString = str.Substring(site1, site2 - site1 - 1);
                            trainInformation = new TrainInformation(getString);
                            trainCode.Add(new TrainNo(trainInformation.trainNo, trainInformation.trainCode, fromStation, toStation, leaveDate, StationInformation, trainInformation.fromStationName, trainInformation.toStationName));
                            show.Add(trainInformation);
                        }
                    }

                    TrainChoose getTrainCode;
                    int from = 0, to = 0;
                    for (int i = 0; i < show.Count(); i++)
                    {
                        from = Convert.ToInt32(show[i].fromStationNo);
                        to = Convert.ToInt32(show[i].toStationNo);
                        getTrainCode = new TrainChoose(from, to, show[i].trainCode);
                        GetAnother.Add(getTrainCode);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("没有查到数据");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请检查网络连接");
            }
        }
    }
}
