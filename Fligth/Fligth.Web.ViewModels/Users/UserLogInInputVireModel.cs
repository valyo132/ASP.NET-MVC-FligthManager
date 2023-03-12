using System.ComponentModel.DataAnnotations;

namespace Fligth.Web.ViewModels.Users
{
    public class UserLogInInputVireModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "Password should be between 6 and 16 characters")]
        public string Password { get; set; }
    }
}
