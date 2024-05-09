using VideoConferenceApi.DTO;

namespace VideoConferenceApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DiscussionController : ControllerBase
{
    private readonly IDiscussionService _discussionService;
    public DiscussionController(IDiscussionService discussionService)
    {
        _discussionService = discussionService;
    }

    [HttpGet("{discussionID}")]
    public async Task<Results<Ok<DiscussionDetailsDTO>, NotFound<string>>> GetDiscussionDetails(int discussionID)
    {
        DiscussionDetailsDTO discussion = await _discussionService.GetDiscussionDetails(discussionID);
        return discussion is null ? TypedResults.NotFound($"invalid discussion id {discussionID}") : TypedResults.Ok(discussion);
    }
}

