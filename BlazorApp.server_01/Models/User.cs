using System.ComponentModel.DataAnnotations;

namespace BlazorApp.server_01.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public required string Name { get; set; }


        [Required]
        public required string Email { get; set; }


        [Required]
        public int Age { get; set; }
        
        public bool IsActive { get; set; } = false;

        [Required]
        public string Skill { get; set; }
    }
}
