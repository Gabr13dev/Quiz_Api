using System.ComponentModel.DataAnnotations;

namespace QuizApi.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }


        public string? Avatar { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
