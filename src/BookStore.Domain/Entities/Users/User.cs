using BookStore.Domain.Commons;
using BookStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public UserRole UserRole { get; set; }
    }
}
