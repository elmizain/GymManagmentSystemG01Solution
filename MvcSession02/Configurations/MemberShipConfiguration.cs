using GymManagmentSystemG01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;namespace GymManagmentSystemG01.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip> 
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("Getdate()");
            builder.HasOne(m => m.plan).WithMany(p => p.MemberShips).HasForeignKey(m => m.PlanId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
