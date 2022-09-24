using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Option
    {
        [Key]
        public int IdOption { get; set; }

        [StringLength(100)]
        public string TitleOption { get; set; }

        [ForeignKey("Question")]
        public int IdQuestion { get; set; }

        public virtual Question Question { get; set; }

        public bool IsCorrect { get; set; }
    }
}
