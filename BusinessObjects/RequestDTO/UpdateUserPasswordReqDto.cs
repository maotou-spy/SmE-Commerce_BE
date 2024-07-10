using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.RequestDTO
{
    public class UpdateUserPasswordReqDto
    {
        [Required(ErrorMessage = "Password is required")]
        public required string OldPassword { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one digit")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public required string RePassword { get; set; }
    }
}