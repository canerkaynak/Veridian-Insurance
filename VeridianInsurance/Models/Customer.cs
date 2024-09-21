namespace VeridianInsurance.Models
{
    public class Customer
    {
        public Customer()
        {
            Policies = new List<Policy>();
        }
        public int Id { get; set; }
        public string TCNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public char Type { get; set; }
        public List<Policy> Policies { get; set; }
    }
}
