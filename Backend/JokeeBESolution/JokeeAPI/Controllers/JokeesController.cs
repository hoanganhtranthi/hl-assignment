using Jokee.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace JokeeAPI.Controllers
{
    [ApiController]
    [Route("api/jokes")]
    public class JokeesController : ControllerBase
    {
        private readonly IJokeService _jokeService;
        public JokeesController(IJokeService jokeService)
        {
            _jokeService = jokeService;
        }
        [HttpGet()]
        public async Task<ActionResult<List<string>>> GetJokees()
        {
            var rs = await _jokeService.GetJokees();
            return Ok(rs);
        }
    }
}