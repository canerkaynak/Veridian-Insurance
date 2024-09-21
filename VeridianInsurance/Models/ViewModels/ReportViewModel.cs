namespace VeridianInsurance.Models.ViewModels
{
    public class OFViewModel
    {
        public string ApprovedBy { get; set; }
        public string FullName { get; set; }
        public int Health { get; set; }
        public int Vehicle { get; set; }
        public int ND { get; set; }
    }

    public class ConsultantPolicyViewModel
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Type { get; set; }
        public int HealthPolicy { get; set; }
        public int VehiclePolicy { get; set; }
        public int NDPolicy { get; set; }
        public int TotalPolicy { get; set; }
    }

    public class ReportViewModel
    {
        public List<OFViewModel> TopOfferConsultant { get; set; }
        public List<OFViewModel> TopPolicyConsultant { get; set; }
        public List<ConsultantPolicyViewModel> AllConsultants { get; set; }
    }
}