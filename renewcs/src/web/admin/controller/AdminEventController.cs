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
    /// <summary>
    /// 이벤트를 검색한다.
    /// </summary>
    /// <param name="search">검색어</param>
    /// <param name="type">이벤트의 타입. type=fcfs,draw 꼴로 표현</param>
    /// <param name="sort">정렬 기준. eventId,name,startTime,endTime,eventType 필드에 대해 정렬 가능. 내림차순 정렬 시 field:desc 로 표현. ex) sort=startTime,endTime:desc,eventId:asc</param>
    /// <param name="page">현재 페이지. 0에서 시작</param>
    /// <param name="size">한번에 검색하는 개수</param>
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

    [HttpGet("{eventId}")]
    public async Task<IActionResult> GetEvent([FromRoute(Name = "eventId")] string eventId) {
      var result = await eventService.GetEventInfo(eventId);
      return Ok(result);
    }

    /// <summary>
    /// 이벤트를 새롭게 생성한다.
    /// </summary>
    /// <param name="dto">이벤트 생성에 필요한 정보를 담은 객체</param>
    [HttpPost]
    public async Task<IActionResult> CreateEvent([FromBody] EventDto dto) {
      if(!ModelState.IsValid) return BadRequest(ModelState);

      await eventService.CreateEvent(dto);
      return Created();
    }

    [HttpPost("/edit")]
    public async Task<IActionResult> EditEvent([FromBody] EventDto dto) {
      await eventService.EditEvent(dto);
      return Ok();
    }
  }
}
