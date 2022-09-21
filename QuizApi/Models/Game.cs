using System.ComponentModel.DataAnnotations;

namespace QuizApi.Models
{
    public class Game
    {
        [Key]
        public int IdGame { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
