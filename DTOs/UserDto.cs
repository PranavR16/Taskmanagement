using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Api.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }
    }
}
