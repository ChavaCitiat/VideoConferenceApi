namespace VideoConferenceApi.BL.Interfaces;

public interface IParticipantService
{
    Task UpdateJoining(object participant);
    Task<IEnumerable<PatricipantDTO>> GetAllParticipantsInDiscussion(int discussionID);

}
