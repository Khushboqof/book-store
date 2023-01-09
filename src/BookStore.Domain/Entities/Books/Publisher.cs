using BookStore.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities.Books
{
    public class Publisher : Auditable
    {
        public string Name { get; set; } = string.Empty;
    }
}
