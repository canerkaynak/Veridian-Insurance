using System.ComponentModel.DataAnnotations;

namespace VeridianInsurance.Models.ViewModels
{
    public class policyViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Policy> Policies { get; set; }
        public List<Health> HealthDetails { get; set; }
        public List<NaturalDisasters> NDDetails { get; set; }
        public List<Vehicle> VehicleDetails { get; set; }
        public List<VehicleInformation> VehicleInformation { get; set; }
        public List<VehicleInsuranceValue> VehicleValue { get; set; }
        public List<Payment> Payments { get; set; }
        public Policy Policy { get; set; }
        public Vehicle Vehicle{ get; set; }
        public Health Health { get; set; }
        public NaturalDisasters ND { get; set; }
        public Dictionary<string, string> PolicyData { get; set; }
    }
}
