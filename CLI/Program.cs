using System;
using DAL.Context;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            DbPrinter printer = new DbPrinter(new Service(new AppDbContext()));

            printer.PrintFullCustomersData();

            Console.ReadKey();
        }
    }
}
