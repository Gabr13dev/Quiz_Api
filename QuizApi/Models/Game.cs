using System.ComponentModel.DataAnnotations;

namespace QuizApi.Models
{
    public class Game
    {
        [Key]
        public int IdGame { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public int IdUser { get; set; }

        public virtual User User { get; set; }
    }
}
