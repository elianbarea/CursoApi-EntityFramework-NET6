using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class User :BaseEntity
    {
        [Required, StringLength(50)]//nombre de usuario no superior a 50C
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string LastName { get; set; } = String.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
