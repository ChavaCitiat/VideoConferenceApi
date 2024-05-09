namespace VideoConferenceApi.Entities;

public class Record
{
    [Key]
    public int Id { get; set; }

    public int ActionCode { get; set; }

    public int ParticipantId { get; set; }

    public int DiscussionId { get; set; }

    public bool Status { get; set; }

    // Navigation properties
    public Participant Participant { get; set; }

    public Discussion Discussion { get; set; }
}