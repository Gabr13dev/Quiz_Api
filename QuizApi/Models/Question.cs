using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Question
    {
        [Key]
        public int IdQuestion { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleQuestion { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}
