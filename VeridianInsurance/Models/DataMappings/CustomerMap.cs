using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridianInsurance.Models;


namespace VeridianInsurance.Models.DataMappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers");

            //builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.TCNo).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Surname).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Type).IsRequired();

            builder.HasIndex(x => x.TCNo);
            builder.HasIndex(x => x.Email);

            builder.Property(x => x.TCNo).HasMaxLength(11).IsFixedLength();
            builder.Property(x => x.Name).HasMaxLength(40);
            builder.Property(x => x.Surname).HasMaxLength(40);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsFixedLength();
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.City).HasMaxLength(40);

            builder.Property(x => x.Id).HasColumnType("int");
            builder.Property(x => x.TCNo).HasColumnType("varchar");
            builder.Property(x => x.Name).HasColumnType("nvarchar");
            builder.Property(x => x.Surname).HasColumnType("nvarchar");
            builder.Property(x => x.DateOfBirth).HasColumnType("date");
            builder.Property(x => x.PhoneNumber).HasColumnType("nvarchar");
            builder.Property(x => x.Email).HasColumnType("nvarchar");
            builder.Property(x => x.City).HasColumnType("nvarchar");
            builder.Property(x => x.Type).HasColumnType("char");

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.TCNo).HasColumnName("tcNo");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Surname).HasColumnName("surname");
            builder.Property(x => x.DateOfBirth).HasColumnName("dateOfBirth");
            builder.Property(x => x.PhoneNumber).HasColumnName("phone");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.City).HasColumnName("city");
            builder.Property(x => x.Type).HasColumnName("type");
        }
    }
}
