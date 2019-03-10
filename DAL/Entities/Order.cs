using System.Collections.Generic;

namespace DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
