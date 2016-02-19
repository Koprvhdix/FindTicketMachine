using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSearch
{
    public class TrainChoose
    {
        public int from { get; set; }
        public int to { get; set; }
        public int time { get; set; }
        public string TrainCode { get; set; }
        public TrainChoose(int from, int to, int time)
        {
            this.from = from;
            this.to = to;
            this.time = time;
        }

        public TrainChoose(int from, int to, string TrainCode)
        {
            this.from = from;
            this.to = to;
            this.TrainCode = TrainCode;
        }
    }
}
