using Fligth.Models;
using Microsoft.EntityFrameworkCore;

namespace Fligth.Data
{
    public class FligthConext : DbContext
    {
        public FligthConext()
        {

        }

        public FligthConext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
