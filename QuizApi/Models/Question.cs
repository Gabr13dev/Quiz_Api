using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Question
    {
        [Key]
        public int IdQuestion { get; set; }

        [Required]
        public string Title { get; set; }

        //[ForeignKey("CorrectOption")]
        //public string? IdCorrectOption { get; set; }

        //public virtual Option? CorrectOption { get; set; }
    }
}
