namespace VeridianInsurance.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int PolicyNo { get; set; }
        public double PayedAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CardHolder { get; set; }
        public Policy Policy { get; set; }
    }
}
