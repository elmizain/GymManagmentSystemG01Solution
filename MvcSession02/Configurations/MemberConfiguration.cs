using GymManagmentSystemG01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    namespace GymManagmentSystemG01.Configurations

    { 
       public class MemberConfiguration:GymUserConfiguration<Member>,IEntityTypeConfiguration<Member>
       {
          public new void Configure(EntityTypeBuilder<Member> builder)
          {
            builder.Property(x=> x.CreatedAt).HasColumnType("datetime2").HasDefaultValueSql("Getdate()");
            base.Configure(builder);
          }


       }


    }
