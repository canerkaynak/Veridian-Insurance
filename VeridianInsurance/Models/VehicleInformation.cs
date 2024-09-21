using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VeridianInsurance.Models
{
    public class VehicleInformation
    {
        [Key]
        public int VehicleID { get; set; }
        public string BrandCode { get; set; }
        public string TypeCode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public VehicleInsuranceValue VehicleInsuranceValue { get; set; }
    }
}
