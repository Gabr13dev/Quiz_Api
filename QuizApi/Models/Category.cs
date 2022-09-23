using System.ComponentModel.DataAnnotations;

namespace QuizApi.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }

        [Required]
        public string NameCategory { get; set; }
    }
}
