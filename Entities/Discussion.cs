namespace VideoConferenceApi.Entities;
public class Discussion
{
    [Key]
    public int Id { get; set; }

    public string Subject { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public bool IsActive { get; set; }

    public int CaseId { get; set; }

    // Navigation properties
    public Case Case { get; set; }

    public ICollection<Participant> Participants { get; set; }

    public ICollection<Record> Records { get; set; }
}
