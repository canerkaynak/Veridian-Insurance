using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeridianInsurance.Models
{
    public class Health
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PolicyNo { get; set; }
        public char IsSmoke { get; set; }
        public char IsHadOperation { get; set; }
        public Policy Policy { get; set; }
    }
}
