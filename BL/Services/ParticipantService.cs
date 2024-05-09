using AutoMapper;


namespace VideoConferenceApi.BL.Services
{
    public class ParticipantService : IParticipantService
    {
        IParticipantRepository _participantRepository;
        IMapper _mapper;
        public ParticipantService(IParticipantRepository participantRepository, IMapper mapper)
        {
            _participantRepository = participantRepository;
            _mapper = mapper;
        }

        public Task UpdateJoining(object participant)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PatricipantDTO>> GetAllParticipantsInDiscussion(int discussionID)
        {
            var allParticipants = await _participantRepository.GetAllParticipantsInDiscussion(discussionID);
            return _mapper.Map<IEnumerable<PatricipantDTO>>(allParticipants);
        }
    }
}
