using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI_Chart_Segment_Color
{
    public class Model
    {
        public string XValue { get; set; }

        public double YValue { get; set; }

        public Model(string name, double count)
        {
            XValue = name;
            YValue = count;
        }
    }
}
