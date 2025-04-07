using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Speaker name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Speaker subject is required.")]
        public string Subject { get; set; }

        // Foreign key linking to SacramentMeeting
        public int SacramentMeetingId { get; set; }
        public SacramentMeeting SacramentMeeting { get; set; }
    }
}
