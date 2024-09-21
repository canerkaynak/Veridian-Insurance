using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeridianInsurance.Models;

namespace VeridianInsurance.Models.DataMappings
{
    public class PaymentMap : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("payments");

            //builder.HasOne(x => x.Policy).WithOne(y => y.Payment).HasForeignKey<Policy>(z => z.PolicyNo).IsRequired();

            builder.Property(x => x.PolicyNo).IsRequired();
            builder.Property(x => x.PayedAmount).IsRequired();
            builder.Property(x => x.PaymentDate).IsRequired();
            builder.Property(x => x.CardHolder).IsRequired();

            builder.Property(x => x.PolicyNo).HasColumnType("int");
            builder.Property(x => x.PayedAmount).HasColumnType("Decimal(19, 4)");
            builder.Property(x => x.PaymentDate).HasColumnType("datetime");
            builder.Property(x => x.CardHolder).HasColumnType("varchar");

            builder.Property(x => x.PolicyNo).HasColumnName("policyNo");
            builder.Property(x => x.PayedAmount).HasColumnName("payedAmount");
            builder.Property(x => x.PaymentDate).HasColumnName("paymentDate");
            builder.Property(x => x.CardHolder).HasColumnName("cardHolder");
        }
    }
}
