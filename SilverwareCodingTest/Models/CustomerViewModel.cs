using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class CustomerViewModel
    {
        public long Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is not valid.")]
        public string Email { get; set; }
        [Display(Name = "Mobile No")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Number is not valid.")]
        [Required]
        public string MobileNo { get; set; }
    }
}
