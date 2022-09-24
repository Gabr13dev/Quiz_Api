using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Game
    {
        [Key]
        public int IdGame { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleGame { get; set; }


        [StringLength(400)]
        public string? UrlImageCoverGame { get; set; }

        [ForeignKey("Category")]
        public int IdCategory { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
