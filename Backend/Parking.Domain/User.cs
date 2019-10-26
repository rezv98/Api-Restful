using System.ComponentModel.DataAnnotations;

namespace Parking.Domain
{
    public class User
    {
        [Required]
        [EmailAddress]
        public string Email{get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}