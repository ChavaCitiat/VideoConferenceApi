namespace VideoConferenceApi.Entities;

public class ActionType
{
    [Key]
    public int Code { get; set; }

    public string Description { get; set; }
}

