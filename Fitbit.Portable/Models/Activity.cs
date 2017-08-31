using System.Collections.Generic;

namespace FitbitSNHP.Models
{
    public class Activity
    {
        public ActivitySummary Summary { get; set; }
        public List<ActivityLog> Activities { get; set; }
        public ActivityGoals Goals { get; set; }

    }
}
