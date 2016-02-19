using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSearch
{
    public class JSON
    {
        public string project { get; set; }
        public string Value { get; set; }
        public List<string> ValueList { get; set; }
        public JSON(string project)
        {
            this.project = project;
            this.ValueList = new List<string>();
        }
        public void getValue(string final)
        {
            int position1, position2, position3;
            position1 = final.IndexOf(project);
            position1 += (project.Count() + 2);
            position2 = final.IndexOf('"', position1);
            position3 = final.IndexOf('"', position2 + 1);
            this.Value = final.Substring(position2 + 1, position3 - position2 - 1);
        }
    }
}
