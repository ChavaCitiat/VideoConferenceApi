namespace VideoConferenceApi.DAL;

public static class MockData
{
    public static List<Case> Cases { get; } = new List<Case>
    {
        new Case { CaseNumber = "CASE001", CreationDate = DateTime.Now.AddDays(-7), Description = "Sample Case 1" },
        new Case { CaseNumber = "CASE002", CreationDate = DateTime.Now.AddDays(-14), Description = "Sample Case 2" }
    };

    public static List<Discussion> Discussions { get; } = new List<Discussion>
    {
        new Discussion { Id = 1, CaseId = 1, Subject = "Discussion 1", StartTime = DateTime.Now.AddHours(-2), EndTime = DateTime.Now.AddHours(-1), IsActive = true },
        new Discussion { Id = 2, CaseId = 2, Subject = "Discussion 2", StartTime = DateTime.Now.AddHours(-4), EndTime = DateTime.Now.AddHours(-3), IsActive = true }
    };

    public static List<Participant> Participants { get; } = new List<Participant>
    {
        new Participant { RecordId = 1, ParticipantId = 101, InvitedBy = 201, Name = "John Doe", Mail = "john.doe@example.com", Telephone = "123-456-7890", RoleId = 1, DiscussionId = 1, PermissionCode = "VIEW", IsActuallyParticipate = true },
        new Participant { RecordId = 2, ParticipantId = 102, InvitedBy = 202, Name = "Jane Smith", Mail = "jane.smith@example.com", Telephone = "987-654-3210", RoleId = 2, DiscussionId = 1, PermissionCode = "VIEW", IsActuallyParticipate = true },
        new Participant { RecordId = 3, ParticipantId = 103, InvitedBy = 201, Name = "Mike Johnson", Mail = "mike.johnson@example.com", Telephone = "555-123-4567", RoleId = 2, DiscussionId = 2, PermissionCode = "VIEW", IsActuallyParticipate = true }
    };

    public static List<Record> Records { get; } = new List<Record>
    {
        new Record { Id = 1, ActionCode = 101, ParticipantId = 101, DiscussionId = 1, Status = true },
        new Record { Id = 2, ActionCode = 102, ParticipantId = 102, DiscussionId = 1, Status = true },
        new Record { Id = 3, ActionCode = 101, ParticipantId = 103, DiscussionId = 2, Status = true }
    };

    public static List<ActionType> ActionTypes { get; } = new List<ActionType>
    {
        new ActionType { Code = 101, Description = "Speak" },
        new ActionType { Code = 102, Description = "Open Camera" },
        new ActionType { Code = 103, Description = "Share Screen" }
    };

    public static List<Role> Roles { get; } = new List<Role>
    {
        new Role { Code = 1, Description = "Judge" },
        new Role { Code = 2, Description = "Representative" }
    };

    public static List<Permission> Permissions { get; } = new List<Permission>
    {
        new Permission { Code = 1, Description = "Admin" },
        new Permission { Code = 2, Description = "Regular" }
    };
}
