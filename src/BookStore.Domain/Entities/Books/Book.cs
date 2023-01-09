using BookStore.Domain.Commons;
using BookStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities.Books
{
    public class Book : Auditable
    {
        public string Title { get; set; } = string.Empty;

        public int PublishYear { get; set; }
        public int NumberOfPage { get; set; }
        public decimal Price { get; set; }
        public Guid Isbn { get; set; }

        public int PublisherId { get; set; }
        [ForeignKey(nameof(PublisherId))]
        public virtual Publisher Publisher { get; set; } = null!;

        public Genre Genre { get; set; }
        public Language Language { get; set; }
    }
}