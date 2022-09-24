using System.ComponentModel.DataAnnotations;

namespace QuizApi.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }

        [Required]
        [StringLength(50)]
        public string NameCategory { get; set; }
    }
}
