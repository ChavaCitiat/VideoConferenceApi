namespace VideoConferenceApi.BL.Interfaces
{
    public interface IDiscussionService
    {
        Task<DiscussionDetailsDTO> GetDiscussionDetails(int discussionID);
    }
}
