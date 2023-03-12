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
        [StringLength(10)]
        public string EGN { get; set; } = null!;

        [Required]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "Password should be between 6 and 16 characters")]
        public string Password { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;
    }
}
