using domain.eventcommon;
using domain.eventcommon.dto;
using domain.eventcommon.service;
using Microsoft.AspNetCore.Mvc;

namespace web.admin
{
  [ApiController]
  [Route("admin/events")]
  public class AdminEventController : ControllerBase
  {
    private readonly IEventService eventService;

    public AdminEventController(IEventService eventService) {
      this.eventService = eventService;
    }

    [HttpGet]
    public async Task<IActionResult> SearchEvents(
      [FromQuery] string search = "",
      [FromQuery] EventType? type = null,
      [FromQuery] string sort = "",
      [FromQuery] int page = 0,
      [FromQuery] int size = 5
    ) {
      if(!ModelState.IsValid) {
        return BadRequest(ModelState);
      }

      var result = await eventService.SearchEvents(search, sort, type, page, size);
      return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEvent([FromBody] EventDto dto) {
      if(!ModelState.IsValid) return BadRequest(ModelState);

      await eventService.CreateEvent(dto);
      return Created();
    }
  }
}
