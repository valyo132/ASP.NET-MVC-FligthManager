using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fligth.Models
{
    public class PlaneFligth
    {
        public PlaneFligth()
        {
            this.Reservations = new HashSet<Reservation>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Destination { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; } = null!;

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
