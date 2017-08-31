using System;
using System.Collections.Generic;

namespace FitbitSNHP.Models
{
    public class TimeSeriesDataListInt
    {
        public List<Data> DataList { get; set; }

        public class Data
        {
            public DateTime DateTime { get; set; }
            public int Value { get; set; }
        }
    }
}