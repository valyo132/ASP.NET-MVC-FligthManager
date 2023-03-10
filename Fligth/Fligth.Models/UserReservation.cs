using System.ComponentModel.DataAnnotations.Schema;

namespace Fligth.Models
{
    public class UserReservation
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;

        [ForeignKey(nameof(Reservation))]
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; } = null!;
    }
}
