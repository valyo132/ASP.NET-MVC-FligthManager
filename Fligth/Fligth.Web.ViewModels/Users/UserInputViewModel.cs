using System.ComponentModel.DataAnnotations;

namespace Fligth.Web.ViewModels.Users
{
    public class UserInputViewModel
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [MinLength(6)]
        [MaxLength(16)]
        public string Password { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;
    }
}
