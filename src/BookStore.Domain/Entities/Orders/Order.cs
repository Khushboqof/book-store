using BookStore.Domain.Commons;
using BookStore.Domain.Entities.Users;
using BookStore.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Domain.Entities.Ordersr
{
    public class Order : Auditable
    {
        public string Address { get; set; } = string.Empty;

        public OrderState OrderState { get; set; }

        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;
    }
}
