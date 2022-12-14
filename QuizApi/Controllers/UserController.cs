using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using QuizApi.Context;
using QuizApi.Models;

namespace QuizApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly QuizDbContext quizDbContext;

        public UserController(QuizDbContext quizDbContext)
        {
            this.quizDbContext = quizDbContext;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(quizDbContext.User.ToList());
        }

        [HttpPost]
        public IActionResult PostUser(User user)
        {
            quizDbContext.User.Add(user);
            quizDbContext.SaveChanges();
            return Ok("Usuario cadastrado com sucesso");
        }

        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            try
            {
                var currentUser = quizDbContext.User.FirstOrDefault(u => u.IdUser == user.IdUser);
                if (currentUser == null)
                {
                    return NotFound("Usuario nao encontrado");
                }
                quizDbContext.Entry(currentUser).CurrentValues.SetValues(user);
                quizDbContext.User.Update(currentUser);
                quizDbContext.SaveChanges();
                return Ok("Usuario alterado com sucesso");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
