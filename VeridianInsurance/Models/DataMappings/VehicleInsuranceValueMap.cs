using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridianInsurance.Models;

namespace VeridianInsurance.Models.DataMappings
{
    public class VehicleInsuranceValueMap : IEntityTypeConfiguration<VehicleInsuranceValue>
    {
        public void Configure(EntityTypeBuilder<VehicleInsuranceValue> builder)
        {
            builder.ToTable("vehicleInsuranceValue");

            //builder.HasKey(x => x.ValueID);
            //builder.HasOne(x => x.VehicleInformation).WithOne(y => y.VehicleInsuranceValue).HasForeignKey<VehicleInformation>(z => z.VehicleID).IsRequired();

            builder.Property(x => x.ValueID).IsRequired();
            builder.Property(x => x.VehicleID).IsRequired();
            builder.Property(x => x.Year).IsRequired();
            builder.Property(x => x.Value).IsRequired();

            builder.Property(x => x.ValueID).HasColumnType("int");
            builder.Property(x => x.VehicleID).HasColumnType("int");
            builder.Property(x => x.Year).HasColumnType("varchar");
            builder.Property(x => x.Value).HasColumnType("Decimal(19, 4)");

            builder.Property(x => x.ValueID).HasColumnName("valuId");
            builder.Property(x => x.VehicleID).HasColumnName("vehicleId");
            builder.Property(x => x.Year).HasColumnName("year");
            builder.Property(x => x.Value).HasColumnName("value");
        }
    }
}
