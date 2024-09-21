using System.ComponentModel.DataAnnotations;

namespace VeridianInsurance.Models
{
    public class VehicleInsuranceValue
    {
        [Key]
        public int ValueID { get; set; }
        public int VehicleID { get; set; }
        public String Year { get; set; }
        public int Value { get; set; }
    }
}
