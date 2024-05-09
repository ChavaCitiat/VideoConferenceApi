namespace VideoConferenceApi.Entities;

public class Role
{
    [Key]
    public int Code { get; set; }

    public string Description { get; set; }
}
