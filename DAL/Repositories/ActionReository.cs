
namespace VideoConferenceApi.DAL.Repositories;

public class ActionReository : IActionRepository
{
    public Task UpdateActionStatus(Action actionToUpdate)
    {

        //TODO : get the action from Actions table by actionCode, discussionId, and participantId 
        //and update status (isOn) of action 
        return Task.CompletedTask;
    }
    

    
}
