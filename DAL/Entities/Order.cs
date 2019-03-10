using System.Collections.Generic;

namespace DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public decimal TotalPrice { get; set; }

        public Customer Customer { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
