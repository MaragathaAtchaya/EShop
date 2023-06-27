using System.ComponentModel.DataAnnotations;

namespace onlineshop.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])" +
            "(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$", 
            ErrorMessage ="Password must contain 1 uppercase letter, 1 lowercase letter, 1 number, "
            + "1 non-alphanumeric and atleast 6 chars")]
        public string Password { get; set; }
    }
}
