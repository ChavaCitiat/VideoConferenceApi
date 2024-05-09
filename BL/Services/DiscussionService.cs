namespace VideoConferenceApi.BL.Services
{
    public class DiscussionService : IDiscussionService
    {
        IDiscussionService _discussionService;
        public DiscussionService(IDiscussionService discussionService)
        {
            _discussionService = discussionService;
        }

        public Task<DiscussionDetailsDTO> GetDiscussionDetails(int discussionID)
        {
            //bring data from DAL
            return null;
        }
    }
}
