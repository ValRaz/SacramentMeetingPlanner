using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Meeting date is required.")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [Required(ErrorMessage = "Conducting leader is required.")]
        public string ConductingLeader { get; set; }

        [Required(ErrorMessage = "Opening song is required.")]
        public string OpeningSong { get; set; }

        [Required(ErrorMessage = "Sacrament hymn is required.")]
        public string SacramentHymn { get; set; }

        [Required(ErrorMessage = "Closing song is required.")]
        public string ClosingSong { get; set; }

        // Optional field for intermediate musical number
        public string? IntermediateMusicalNumber { get; set; }

        [Required(ErrorMessage = "Opening prayer is required.")]
        public string OpeningPrayer { get; set; }

        [Required(ErrorMessage = "Closing prayer is required.")]
        public string ClosingPrayer { get; set; }

        // Zero to n speakers
        public List<Speaker> Speakers { get; set; } = new();
    }
}
