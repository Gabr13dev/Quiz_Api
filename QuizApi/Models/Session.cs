using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Session
    {
        [Key]
        public Guid IdSession { get; set; }

        [Required]
        public int Score { get; set; }

        [ForeignKey("User")]
        public int IdUser { get; set; }

        [ForeignKey("Game")]
        public int IdGame { get; set; }

        public virtual User User { get; set; }

        public virtual Game Game { get; set; }

    }
}
