

namespace VideoConferenceApi.Entities;

public class Case
{
    [Key]
    [Column(TypeName = "varchar(255)")]
    public string CaseNumber { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? ClosingDate { get; set; }

    public string Description { get; set; }

    // Navigation property to Discussions (one-to-many)
    public ICollection<Discussion> Discussions { get; set; }
}
