using Fligth.Models;
using Microsoft.EntityFrameworkCore;

namespace Fligth.Data
{
    public class FligthManagerContext : DbContext
    {
        public FligthManagerContext()
        {

        }

        public FligthManagerContext(DbContextOptions options)
            : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; } = null!;

        public virtual DbSet<Reservation> Reservations { get; set; } = null!;

        public virtual DbSet<Company> Companies { get; set; } = null!;

        public virtual DbSet<PlaneFligth> PlaneFligths { get; set; } = null!;

        public virtual DbSet<UserReservation> UsersReservations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserReservation>()
                .HasKey(ur => new { ur.ReservationId, ur.UserId });
        }
    }
}
