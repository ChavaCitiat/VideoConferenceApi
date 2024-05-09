namespace VideoConferenceApi.Entities;

public class Action
{
    public int Id { get; set; }
    public int ActionCode { get; set; }
    public int ParticipantId { get; set; }
    public int DiscussionId { get; set; }
    public bool IsOn { get; set; }

}
