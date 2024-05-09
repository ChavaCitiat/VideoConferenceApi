namespace VideoConferenceApi.Entities;

public class Permission
{
    [Key]
    public int Code { get; set; }

    public string Description { get; set; }
}

