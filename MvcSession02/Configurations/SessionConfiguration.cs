using GymManagmentSystemG01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

 namespace GymManagmentSystemG01.Configurations
 {
    public class SessionConfiguration:IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("Getdate()");
            builder.HasOne(s => s.Trainer).WithMany(t => t.Sessions).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("SessionoCapacityContraint", "Capacity between 1 and 25");
                t.HasCheckConstraint("SessionEndDateAfterStartDate", "StartDate < EndDate");
            });
        }
    }
 }
