using System.ComponentModel.DataAnnotations;

namespace QuizApi.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }

        [StringLength(200)]
        public string? Avatar { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
