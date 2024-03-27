using System.ComponentModel.DataAnnotations;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        [MinLength(5, ErrorMessage = "Must be 5-50 characters.")]
        [MaxLength(50, ErrorMessage = "Must be 5-50 characters.")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(30, ErrorMessage = "Can be at most 30 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }
}
