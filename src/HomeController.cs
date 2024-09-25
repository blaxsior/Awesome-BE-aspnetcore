
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api.v1
{
  /// <summary>
  /// Home을 의미하는 주석
  /// </summary>
  [Route("api/v1/")]
  [ApiController]
  public class HomeController : ControllerBase
  {
    /// <summary>
    ///  this is test
    /// </summary>
    [HttpGet]
    public IActionResult IndexPage()
    {
      return Ok("hello, world!");
    }
  }
}