using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using VeridianInsurance.Models.DataMappings;

namespace VeridianInsurance.Models
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Policy>().HasOne(e => e.Health).WithOne(e => e.Policy).HasForeignKey<Health>(e=>e.PolicyNo);
            //modelBuilder.Entity<Policy>().HasOne(e => e.NaturalDisasters).WithOne(e => e.Policy).HasForeignKey<NaturalDisasters>(e => e.PolicyNo);
            //modelBuilder.Entity<Policy>().HasOne(e => e.Vehicle).WithOne(e => e.Policy).HasForeignKey<Vehicle>(e => e.PolicyNo);
            //modelBuilder.Entity<Policy>().HasOne(e => e.Payment).WithOne(e => e.Policy).HasForeignKey<Payment>(e => e.PolicyNo);

            //modelBuilder.Entity<VehicleInformation>().HasOne(e => e.VehicleInsuranceValue).WithOne(e => e.VehicleInformation).HasForeignKey<VehicleInsuranceValue>(e=>e.VehicleID);


            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new HealthMap());
            modelBuilder.ApplyConfiguration(new NaturalDisastersMap());
            modelBuilder.ApplyConfiguration(new PaymentMap());
            modelBuilder.ApplyConfiguration(new PolicyMap());
            modelBuilder.ApplyConfiguration(new VehicleInformationMap());
            modelBuilder.ApplyConfiguration(new VehicleInsuranceValueMap());
            modelBuilder.ApplyConfiguration(new VehicleMap());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Health> Healths { get; set; }
        public DbSet<NaturalDisasters> NaturalDisasters { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<VehicleInformation> VehicleInformation { get; set; }
        public DbSet<VehicleInsuranceValue> VehicleInsuranceValues { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
