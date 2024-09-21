namespace VeridianInsurance.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int PolicyNo { get; set; }
        public string PlateCityCode { get; set; }
        public string PlateCode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string ChassisSerialNumber { get; set; }
        public Policy Policy { get; set; }
    }
}
