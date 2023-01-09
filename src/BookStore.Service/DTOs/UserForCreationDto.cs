using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.DTOs
{
    public class UserForCreationDto 
    {
        [MaxLength(25), MinLength(2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required, MaxLength(13), MinLength(13)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(), MinLength(8)]
        public string Password { get; set; } = string.Empty;
    }
}
