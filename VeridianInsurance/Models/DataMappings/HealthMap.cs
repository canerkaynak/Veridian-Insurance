using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridianInsurance.Models;

namespace VeridianInsurance.Models.DataMappings
{
    public class HealthMap : IEntityTypeConfiguration<Health>
    {
        public void Configure(EntityTypeBuilder<Health> builder)
        {
            builder.ToTable("health");

            //builder.HasOne(x => x.Policy).WithOne(y => y.Health).HasForeignKey<Health>(z => z.PolicyNo).IsRequired();

            builder.Property(x => x.PolicyNo).IsRequired();
            builder.Property(x => x.IsSmoke).IsRequired();
            builder.Property(x => x.IsHadOperation).IsRequired();

            builder.Property(x => x.PolicyNo).HasColumnType("int");
            builder.Property(x => x.IsSmoke).HasColumnType("char");
            builder.Property(x => x.IsHadOperation).HasColumnType("char");

            builder.Property(x => x.PolicyNo).HasColumnName("policyNo");
            builder.Property(x => x.IsSmoke).HasColumnName("isSmoke");
            builder.Property(x => x.IsHadOperation).HasColumnName("isHadOperation");
        }
    }
}
