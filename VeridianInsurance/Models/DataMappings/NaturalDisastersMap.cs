using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridianInsurance.Models;

namespace VeridianInsurance.Models.DataMappings
{
    public class NaturalDisastersMap : IEntityTypeConfiguration<NaturalDisasters>
    {
        public void Configure(EntityTypeBuilder<NaturalDisasters> builder)
        {
            builder.ToTable("naturalDisasters");

            //builder.HasOne(x => x.Policy).WithOne(y => y.NaturalDisasters).HasForeignKey<NaturalDisasters>(z => z.PolicyNo).IsRequired();

            builder.Property(x => x.PolicyNo).IsRequired();
            builder.Property(x => x.Uavt).IsRequired();
            builder.Property(x => x.Area).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.BuildingAge).IsRequired();
            builder.Property(x => x.Floor).IsRequired();

            builder.Property(x => x.Uavt).HasMaxLength(10).IsFixedLength();
            builder.Property(x => x.Type).HasMaxLength(50);

            builder.Property(x => x.PolicyNo).HasColumnType("int");
            builder.Property(x => x.Uavt).HasColumnType("varchar");
            builder.Property(x => x.Area).HasColumnType("char");
            builder.Property(x => x.Type).HasColumnType("varchar");
            builder.Property(x => x.BuildingAge).HasColumnType("int");
            builder.Property(x => x.Floor).HasColumnType("int");

            builder.Property(x => x.PolicyNo).HasColumnName("policyNo");
            builder.Property(x => x.Uavt).HasColumnName("uavt");
            builder.Property(x => x.Area).HasColumnName("area");
            builder.Property(x => x.Type).HasColumnName("type");
            builder.Property(x => x.BuildingAge).HasColumnName("buildingAge");
            builder.Property(x => x.Floor).HasColumnName("floor");
        }
    }
}
