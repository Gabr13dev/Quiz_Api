using Microsoft.AspNetCore.Mvc;
using QuizApi.Context;

namespace QuizApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private readonly QuizDbContext quizDbContext;

        public GameController(QuizDbContext quizDbContext)
        {
            this.quizDbContext = quizDbContext;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(quizDbContext.Game.ToList());
        }
    }
}
