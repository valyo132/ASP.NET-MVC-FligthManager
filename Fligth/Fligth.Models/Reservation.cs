using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fligth.Models
{
    public class Reservation
    {
        public Reservation()
        {
            this.UserReservations = new HashSet<UserReservation>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Unicode(true)]
        [StringLength(50)]
        public string Destination { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Fligth))]
        public int FligthId { get; set; }
        public virtual PlaneFligth Fligth { get; set; } = null!;

        public virtual ICollection<UserReservation> UserReservations { get; set; }
    }
}
