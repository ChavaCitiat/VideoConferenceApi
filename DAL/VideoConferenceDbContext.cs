namespace VideoConferenceApi.DAL;

public class VideoConferenceDbContext: DbContext
{
    public DbSet<Case> Cases { get; set; }
    public DbSet<Discussion> Discussions { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<Record> Records { get; set; }
    public DbSet<ActionType> ActionTypes { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure primary keys, relationships, and other model-specific configurations here

        modelBuilder.Entity<Case>(entity =>
        {
            entity.HasKey(e => e.CaseNumber);
        });

        modelBuilder.Entity<Discussion>(entity =>
        {
            entity.HasMany(d => d.Participants)
                .WithOne(ip => ip.Discussion)
                .HasForeignKey(ip => ip.DiscussionId);
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasKey(ip => ip.RecordId);

            // Define foreign key relationships
            entity.HasOne(ip => ip.Discussion)
                .WithMany(d => d.Participants)
                .HasForeignKey(ip => ip.DiscussionId);

            // Other configurations as needed
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.HasKey(r => r.Id);

            // Define foreign key relationships
            entity.HasOne(r => r.Participant)
                .WithMany()
                .HasForeignKey(r => r.ParticipantId);

            entity.HasOne(r => r.Discussion)
                .WithMany(d => d.Records)
                .HasForeignKey(r => r.DiscussionId);

            // Other configurations as needed
        });

        // Configure other entity relationships, primary keys, etc.
    }
}


