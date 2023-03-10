using System.ComponentModel.DataAnnotations;

namespace Fligth.Models
{
    public class Company
    {
        public Company()
        {
            this.Fligths = new HashSet<PlaneFligth>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public string Location { get; set; } = null!;

        public virtual ICollection<PlaneFligth> Fligths { get; set; }
    }
}
