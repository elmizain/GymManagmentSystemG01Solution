using GymManagmentSystemG01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymManagmentSystemG01.Configurations
{
    public class PlanConfiguration: IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("Getdate()");
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("Plan_DurationCheck", "DurationDays between 1 and 365");
            });
        }
    }
    
    
     
    
}
