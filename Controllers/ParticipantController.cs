namespace VideoConferenceApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ParticipantController : ControllerBase
{
    private readonly IParticipantService _participantService;
    public ParticipantController(IParticipantService participantService)
    {
        _participantService = participantService;

    }

    [HttpGet("GetAll{discussionID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Results<Ok<IEnumerable<PatricipantDTO>>, NotFound<string>>))]
    public async Task<Results<Ok<IEnumerable<PatricipantDTO>>, NotFound<string>>> GetAllParticipantsInDiscussion(int discussionID)
    {
        IEnumerable<PatricipantDTO> participants = await _participantService.GetAllParticipantsInDiscussion(discussionID);
        return participants is null ? TypedResults.NotFound($"invalid discussion id {discussionID}") : TypedResults.Ok(participants);
    }

    [HttpPut("UpdateJoining")]
    public async Task<IActionResult> UpdateJoining([FromBody] int participantId)
    {
        await _participantService.UpdateJoining(participantId);
        return Ok();
    }
}



/* [HttpPost]
 public ActionResult<Book> Create(Book book)
 {
     _context.Books.Add(book);
     _context.SaveChanges();
     return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
 }

 [HttpPut("{id}")]
 public IActionResult Update(int id, Book book)
 {
     if (id != book.Id)
     {
         return BadRequest();
     }

     _context.Entry(book).State = EntityState.Modified;
     _context.SaveChanges();

     return NoContent();
 }

 [HttpDelete("{id}")]
 public IActionResult Delete(int id)
 {
     var book = _context.Books.Find(id);
     if (book == null)
     {
         return NotFound();
     }

     _context.Books.Remove(book);
     _context.SaveChanges();

     return NoContent();
 }*/


