using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeridianInsurance.Models
{
    public class Policy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PolicyNo { get; set; }
        public int CustomerID { get; set; }
        public char Status { get; set; }
        public string BranchCode { get; set; }
        public int PriceOfThePolicy { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Customer Customer { get; set; }
        public Health? Health { get; set; }
        public NaturalDisasters? NaturalDisasters { get; set; }
        public Vehicle? Vehicle { get; set; }
        public Payment? Payment { get; set; }
    }
}
