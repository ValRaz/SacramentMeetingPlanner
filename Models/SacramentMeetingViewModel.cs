using System.Collections.Generic;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeetingViewModel
    {
        public SacramentMeeting Meeting { get; set; } = new();
        public List<Speaker> Speakers { get; set; } = new();
    }
}
