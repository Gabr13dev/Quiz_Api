using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizApi.Context;
using QuizApi.Models;

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

        [Route("GetAllGames")]
        [HttpGet]
        public IActionResult GetAllGames()
        {
            var listGames = quizDbContext.Game.Include(c => c.Category).ToList();
            return Ok(listGames);
        }

        [Route("GetGame/{id}")]
        [HttpGet]
        public IActionResult GetGame(string id)
        {
            try
            {
                var game = quizDbContext.Game.Include(c => c.Category).FirstOrDefault(g => g.IdGame == Convert.ToInt32(id));
                if (game == null)
                {
                    return NotFound("Game não encontrado");
                }
                return Ok(game);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult PostGame(Game game)
        {
            quizDbContext.Game.Add(game);
            quizDbContext.SaveChanges();
            return Ok("Game cadastrado com sucesso");
        }

        [HttpPut]
        public IActionResult UpdateGame(Game game)
        {
            try
            {
                var currentGame = quizDbContext.Game.FirstOrDefault(g => g.IdGame == game.IdGame);
                if (currentGame == null)
                {
                    return NotFound("Game nao encontrado");
                }
                quizDbContext.Entry(currentGame).CurrentValues.SetValues(game);
                quizDbContext.Game.Update(currentGame);
                quizDbContext.SaveChanges();
                return Ok("Game alterado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
