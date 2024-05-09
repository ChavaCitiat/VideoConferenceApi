using AutoMapper;

namespace VideoConferenceApi.BL.Mapping;

public class ActionProfile : Profile
{
    public ActionProfile()
    {
        CreateMap<Action, ActionDTO>();
    }

}
