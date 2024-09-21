using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridianInsurance.Models;

namespace VeridianInsurance.Models.DataMappings
{
    public class VehicleInformationMap : IEntityTypeConfiguration<VehicleInformation>
    {
        public void Configure(EntityTypeBuilder<VehicleInformation> builder)
        {
            builder.ToTable("vehicleInformation");

            builder.HasOne(e => e.VehicleInsuranceValue).WithOne().HasForeignKey<VehicleInsuranceValue>(e => e.VehicleID);

            //builder.HasKey(x => x.VehicleID);

            builder.Property(x => x.VehicleID).IsRequired();
            builder.Property(x => x.BrandCode).IsRequired();
            builder.Property(x => x.TypeCode).IsRequired();
            builder.Property(x => x.Brand).IsRequired();
            builder.Property(x => x.Model).IsRequired();

            builder.Property(x => x.BrandCode).HasMaxLength(5);
            builder.Property(x => x.TypeCode).HasMaxLength(5);
            builder.Property(x => x.Brand).HasMaxLength(50);
            builder.Property(x => x.Model).HasMaxLength(50);

            builder.Property(x => x.VehicleID).HasColumnType("int");
            builder.Property(x => x.BrandCode).HasColumnType("varchar");
            builder.Property(x => x.TypeCode).HasColumnType("varchar");
            builder.Property(x => x.Brand).HasColumnType("varchar");
            builder.Property(x => x.Model).HasColumnType("varchar");

            builder.Property(x => x.VehicleID).HasColumnName("vehicleId");
            builder.Property(x => x.BrandCode).HasColumnName("brandCode");
            builder.Property(x => x.TypeCode).HasColumnName("typeCode");
            builder.Property(x => x.Brand).HasColumnName("brand");
            builder.Property(x => x.Model).HasColumnName("model");
        }
    }
}
