namespace VideoConferenceApi.Entities;

public class Participant
{
    [Key]
    public int RecordId { get; set; }

    public int ParticipantId { get; set; }

    public int InvitedBy { get; set; }

    public string Name { get; set; }

    public string Mail { get; set; }

    public string Telephone { get; set; }

    [ForeignKey("RoleId")]
    public int RoleId { get; set; }
    public Role Role { get; set; }

    [ForeignKey("DiscussionId")]
    public int DiscussionId { get; set; }
    public Discussion Discussion { get; set; }

    [ForeignKey("PermissionCode")]
    public string PermissionCode { get; set; }
    public Permission Permission { get; set; }

    public bool IsActuallyParticipate { get; set; }

    public ICollection<Action> Actions { get; set; }
}