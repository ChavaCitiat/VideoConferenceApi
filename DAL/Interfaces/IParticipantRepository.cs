using VideoConferenceApi.Entities;

namespace VideoConferenceApi.DAL.Interfaces;

public interface IParticipantRepository
{
    Task<IEnumerable<Participant>> GetAllParticipantsInDiscussion(int discussionId);
}
