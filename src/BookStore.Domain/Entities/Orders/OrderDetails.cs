using BookStore.Domain.Commons;
using BookStore.Domain.Entities.Ordersr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities.Orders
{
    public class OrderDetails : Auditable
    {
        public int Count { get; set; }

        public int OrderId { get; set;}
        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; } = null!;
    }
}