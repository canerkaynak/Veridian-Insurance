using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridianInsurance.Models;

namespace VeridianInsurance.Models.DataMappings
{
    public class VehicleMap : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("vehicle");

            //builder.HasOne(x => x.Policy).WithOne(y => y.Vehicle).HasForeignKey<Vehicle>(z => z.PolicyNo).IsRequired();

            builder.Property(x => x.PolicyNo).IsRequired();
            builder.Property(x => x.PlateCityCode).IsRequired();
            builder.Property(x => x.PlateCode).IsRequired();
            builder.Property(x => x.Brand).IsRequired();
            builder.Property(x => x.Model).IsRequired();
            builder.Property(x => x.ModelYear).IsRequired();
            builder.Property(x => x.ChassisSerialNumber).IsRequired();

            builder.Property(x => x.PlateCityCode).HasMaxLength(2).IsFixedLength();
            builder.Property(x => x.PlateCode).HasMaxLength(10);
            builder.Property(x => x.Brand).HasMaxLength(50);
            builder.Property(x => x.Model).HasMaxLength(50);
            builder.Property(x => x.ChassisSerialNumber).HasMaxLength(17).IsFixedLength();

            builder.Property(x => x.PolicyNo).HasColumnType("int");
            builder.Property(x => x.PlateCityCode).HasColumnType("varchar");
            builder.Property(x => x.PlateCode).HasColumnType("varchar");
            builder.Property(x => x.Brand).HasColumnType("varchar");
            builder.Property(x => x.Model).HasColumnType("varchar");
            builder.Property(x => x.ModelYear).HasColumnType("int");
            builder.Property(x => x.ChassisSerialNumber).HasColumnType("varchar");

            builder.Property(x => x.PolicyNo).HasColumnName("policyNo");
            builder.Property(x => x.PlateCityCode).HasColumnName("plateCityCode");
            builder.Property(x => x.PlateCode).HasColumnName("plateCode");
            builder.Property(x => x.Brand).HasColumnName("brand");
            builder.Property(x => x.Model).HasColumnName("model");
            builder.Property(x => x.ModelYear).HasColumnName("modelYear");
            builder.Property(x => x.ChassisSerialNumber).HasColumnName("chassisSerialNumber");
        }
    }
}
