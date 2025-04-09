using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class Meeting
{
    public int Id { get; set; } 
    [Required(ErrorMessage = "Conducting leader is required.")]
    [Display(Name = "Conducting Leader")]
    public string? ConductingLeader { get; set; }
    [Required(ErrorMessage = "Meeting date is required.")]
    [Display(Name = "Meeting Date")]
    [DataType(DataType.Date)]
    public DateTime MeetingDate { get; set; }
    [Required(ErrorMessage = "Opening prayer is required.")]
    [Display(Name = "Opening Prayer")]
    public string? OpeningPrayer { get; set; }
    [Required(ErrorMessage = "Closing prayer is required.")]
    [Display(Name = "Closing Prayer")]
    public string? ClosingPrayer { get; set; }
    [Display(Name = "Talk Subjects")]
    public string? TalkSubjects { get; set; }
    [Display(Name = "Opening Hymn")]
    [Required(ErrorMessage = "Opening song is required.")]
    public int OpeningHymn { get; set; }
    [Required(ErrorMessage = "Intermediate song is required.")]
    [Display(Name = "Intermediate Hymn")]
    public int IntermediateHymn { get; set; }
    [Required(ErrorMessage = "Closing song is required.")]
    [Display(Name = "Closing Hymn")]
    public int ClosingHymn { get; set; }
}