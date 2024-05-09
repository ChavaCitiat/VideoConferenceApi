
using AutoMapper;
using VideoConferenceApi.BL.Interfaces;

namespace VideoConferenceApi.BL.Services;

public class ActionService : IActionService
{
    IActionRepository _actionRepository;
    IParticipantRepository _participantRepository;
    IMapper _mapper;
    public ActionService(IActionRepository actionRepository,
                        IParticipantRepository participantRepository,
                        IMapper mapper)
    {
        _actionRepository = actionRepository;
        _mapper = mapper;
        _participantRepository = participantRepository;
    }
    public Task UpdateActionStatus(ActionDTO actionDTO)
    {
        var action = _mapper.Map<Action>(actionDTO);
        return _actionRepository.UpdateActionStatus(action);
    }

    public async Task MuteAllParticipant(int discussionID, int participantID)
    {
        var partipantsToMute = await _participantRepository.GetAllParticipantsInDiscussion(discussionID);
        partipantsToMute.ToList().RemoveAll(p=> p.ParticipantId == participantID);

        foreach (var participant in partipantsToMute)
        {
            var speakAction = participant.Actions.ToList().Find(p => p.ActionCode == (int)Enums.ActionTypes.Speak);
            await _actionRepository.UpdateActionStatus(speakAction);
        }
    }

    public Task<bool> IsUserAdmin(int discussionID, int participantId)
    {
        throw new NotImplementedException();
    }
}
