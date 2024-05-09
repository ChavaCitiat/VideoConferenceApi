namespace VideoConferenceApi.DTO;

public class PatricipantDTO
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Permission { get; set; }
    public List<ActionDTO> ActionsStatus { get; set; }
    public required string DiscussionId { get; set; }
}
