
namespace VideoConferenceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IActionService _actionService;
        public ActionController(IActionService actionService)
        {
            _actionService = actionService;
        }


        [HttpPut("update")]
        public async Task<Ok> UpdateActionStatus(ActionDTO actionDTO)
        {
            await _actionService.UpdateActionStatus(actionDTO);
            return TypedResults.Ok();
        }


        [HttpPut("MuteAllParticipant")]
        public async Task<IActionResult> MuteAllParticipant(int discussionID, int participantId)
        {
            var isAllowed = await _actionService.IsUserAdmin(discussionID, participantId);
            if (!isAllowed)
            {
                return Unauthorized();
            }
            await _actionService.MuteAllParticipant(discussionID, participantId);
            return Ok();


        }





    }
}
