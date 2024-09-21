using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridianInsurance.Models;


namespace VeridianInsurance.Models.DataMappings
{
    public class PolicyMap : IEntityTypeConfiguration<Policy>
    {
        public void Configure(EntityTypeBuilder<Policy> builder)
        {
            builder.ToTable("policies");

            builder.HasOne(e => e.Health).WithOne(e => e.Policy).HasForeignKey<Health>(e => e.PolicyNo);
            builder.HasOne(e => e.NaturalDisasters).WithOne(e => e.Policy).HasForeignKey<NaturalDisasters>(e => e.PolicyNo);
            builder.HasOne(e => e.Vehicle).WithOne(e => e.Policy).HasForeignKey<Vehicle>(e => e.PolicyNo);
            builder.HasOne(e => e.Payment).WithOne(e => e.Policy).HasForeignKey<Payment>(e => e.PolicyNo);

            //builder.HasKey(x => x.PolicyNo);
            //builder.HasOne(x => x.Customer).WithMany(y => y.Policies).HasForeignKey(z => z.CustomerID).IsRequired();

            builder.Property(x => x.PolicyNo).IsRequired();
            builder.Property(x => x.CustomerID).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.BranchCode).IsRequired();
            builder.Property(x => x.PriceOfThePolicy).IsRequired();
            builder.Property(x => x.ApprovedBy).IsRequired();
            builder.Property(x => x.DateOfIssue).IsRequired();

            builder.Property(x => x.BranchCode).HasMaxLength(3).IsFixedLength();
            builder.Property(x => x.ApprovedBy).HasMaxLength(50);

            builder.Property(x => x.PolicyNo).HasColumnType("int");
            builder.Property(x => x.CustomerID).HasColumnType("int");
            builder.Property(x => x.Status).HasColumnType("char");
            builder.Property(x => x.BranchCode).HasColumnType("varchar");
            builder.Property(x => x.PriceOfThePolicy).HasColumnType("money");
            builder.Property(x => x.ApprovedBy).HasColumnType("nvarchar");
            builder.Property(x => x.DateOfIssue).HasColumnType("datetime");

            builder.Property(x => x.PolicyNo).HasColumnName("policyNo");
            builder.Property(x => x.CustomerID).HasColumnName("customerId");
            builder.Property(x => x.Status).HasColumnName("status");
            builder.Property(x => x.BranchCode).HasColumnName("branchCode");
            builder.Property(x => x.PriceOfThePolicy).HasColumnName("priceOfThePolicy");
            builder.Property(x => x.ApprovedBy).HasColumnName("approvedBy");
            builder.Property(x => x.DateOfIssue).HasColumnName("dateOfIssue");
        }
    }
}
