using System.Collections.Generic;

namespace FitbitSNHP.Api.Portable.Models
{
    public class SleepData
    {
        public List<SleepLog> Sleep { get; set; }
        public SleepSummary Summary { get; set; }
    }
}