using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.RequestDTO
{
    public class UpdateUserReqDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public required string Email {  get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Phone number must start with 0 and have 10 digits in total")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        public required string FullName { get; set; }
    }
}
