namespace VideoConferenceApi.BL.Interfaces;

public interface IActionService
{
    Task<bool> IsUserAdmin(int discussionID, int participantId);
    Task MuteAllParticipant(int discussionID, int participantId);
    Task UpdateActionStatus(ActionDTO actionDTO);
}
