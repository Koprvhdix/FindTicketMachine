using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSearch
{
    public class Station
    {
        public string chinese { get; set; }
        public string code { get; set; }
        public Station(string chinese, string code)
        {
            this.chinese = chinese;
            this.code = code;
        }
    }
}
