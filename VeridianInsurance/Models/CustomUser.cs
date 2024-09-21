using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace VeridianInsurance.Models
{
    public class CustomUser : IdentityUser
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Adress")]
        public string City { get; set; }
        public string Town { get; set; }
        public char Type { get; set; }
    }
}
