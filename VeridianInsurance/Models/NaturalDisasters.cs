namespace VeridianInsurance.Models
{
    public class NaturalDisasters
    {
        public int Id { get; set; }
        public int PolicyNo { get; set; }
        public string Uavt { get; set; }
        public int Area { get; set; }
        public string Type { get; set; }
        public int BuildingAge { get; set; }
        public int Floor { get; set; }
        public Policy Policy { get; set; }
    }
}
