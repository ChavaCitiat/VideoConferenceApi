using VideoConferenceApi.DAL.Interfaces;
using VideoConferenceApi.Entities;

namespace VideoConferenceApi.DAL.Repositories;

public class ParticipantRepository : IParticipantRepository
{
    public Task<IEnumerable<Participant>> GetAllParticipantsInDiscussion(int discussionId)
    {
        var participantsInDiscussion = MockData.Participants.FindAll(p => p.DiscussionId == discussionId);
        return Task.FromResult(participantsInDiscussion.AsEnumerable());
    }
}
