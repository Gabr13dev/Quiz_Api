using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Context;

namespace QuizApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly QuizDbContext quizDbContext;

        public CategoryController(QuizDbContext quizDbContext)
        {
            this.quizDbContext = quizDbContext;
        }

        [HttpGet]
        public IActionResult GetCategory()
        {
            return Ok(quizDbContext.Category.ToList());
        }
    }
}
