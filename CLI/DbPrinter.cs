using System;

namespace CLI
{
    public class DbPrinter
    {
        private Service _service;

        public DbPrinter(Service service)
        {
            _service = service;
        }

        public void PrintItems()
        {
            var items = _service.GetItems();

            foreach (var item in items)
            {
                Console.WriteLine($"Id: {item.Id} Description: {item.Description} Price: {item.Price}");
            }
        }

        public void PrintOrders()
        {
            var orders = _service.GetOrders();

            foreach (var order in orders)
            {
                Console.WriteLine($"Id: {order.Id} CustomerId: {order.CustomerId} TotalPrice: {order.TotalPrice}");
            }
        }

        public void PrintOrderItems()
        {
            var orderItems = _service.GetOrderItems();

            foreach (var orderItem in orderItems)
            {
                Console.WriteLine($"ItemId: {orderItem.ItemId} OrderId: {orderItem.OrderId} Quantity: {orderItem.Quantity} " +
                    $"Total: {orderItem.Total}");
            }
        }

        public void PrintCustomers()
        {
            var customers = _service.GetCustomers();

            foreach (var customer in customers)
            {
                Console.WriteLine($"Id: {customer.Id} FirstName: {customer.FirstName} LastName: {customer.LastName}" +
                    $" Patronym: {customer.Patronym} Address: {customer.Address} City: {customer.City} State: {customer.State}");
            }
        }

        public void PrintFullCustomersData()
        {
            var customers = _service.GetFullCustomersData();

            Console.WriteLine("\n-+-+-+-+-+-+-+-+-Customers---------------\n");

            foreach (var customer in customers)
            {
                Console.WriteLine($"FirstName: {customer.FirstName} LastName: {customer.LastName}" +
                    $"Patronym: {customer.Patronym} Address: {customer.Address} City: {customer.City} State: {customer.State}");

                var orders = customer.Orders;

                Console.WriteLine("\n------------------Orders******************\n");

                foreach (var order in orders)
                {
                    Console.WriteLine($"\t TotalPrice: {order.TotalPrice}");

                    var orderItems = order.OrderItems;

                    Console.WriteLine("\n******************Items-----------------\n");

                    foreach (var orderItem in orderItems)
                    {
                        Console.WriteLine($"\t\t ItemDescription: {orderItem.Item.Description} Quantity: {orderItem.Quantity} Total: {orderItem.Total}");
                    }

                    Console.WriteLine("\n___________________________________________________\n");
                }
            }
        }
    }
}

