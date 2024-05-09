using AutoMapper;

namespace VideoConferenceApi.BL.Mapping;

public class ParticipantProfie : Profile
{
    public ParticipantProfie()
    {
        CreateMap<Participant, PatricipantDTO>()
            .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.Description))
            .ForMember(dest => dest.Permission, opt => opt.MapFrom(src => src.Permission.Code))
            .ForMember(dest => dest.ActionsStatus, opt => opt.MapFrom(src => MapActionList(src.Actions)));
    }

    private List<ActionDTO> MapActionList(ICollection<Entities.Action> actions)
    {
        if (actions == null)
            return new List<ActionDTO>();

        return actions.Select(a => new ActionDTO
        {
            ActionCode = a.ActionCode,
            IsOn = a.IsOn
        }).ToList();
    }
}
