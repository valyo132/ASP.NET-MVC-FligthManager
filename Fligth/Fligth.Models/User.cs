using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fligth.Models
{
    public class User
    {
        public User()
        {
            this.UserReservations = new HashSet<UserReservation>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Unicode(true)]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Unicode(true)]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [MinLength(6)]
        [MaxLength(16)]
        public string Password { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(10)]
        public string EGN { get; set; } = null!;

        public virtual ICollection<UserReservation> UserReservations { get; set; }
    }
}
