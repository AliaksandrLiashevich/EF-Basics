using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDbContext _context = new AppDbContext();

            var items = _context.Items.ToList();
        }
    }
}
