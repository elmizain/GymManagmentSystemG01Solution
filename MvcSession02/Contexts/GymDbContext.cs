using GymManagmentSystemG01.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace GymManagmentSystemG01.Contexts
{
    public class GymDbContext: DbContext
    {

        public GymDbContext(DbContextOptions options):base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=GymDbG01;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region DbSet
        public DbSet<Trainer> Trainers{ get; set; }
        public DbSet<Member> Members { get; set; }

        public DbSet<MemberShip> MemberShip { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Session> Sessions{ get; set; }
        #endregion
    }
}
