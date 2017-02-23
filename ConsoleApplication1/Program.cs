using DevStormMvc.Data.Infrastructure;
using Domain.Entities;
using Domain.Entities.ComplexType;
using ServicesSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("debut");
            IServiceProduct s = new ServiceProduct();
            Category c = new Category { Name = "Test" };
            Product p = new Product { Name = "Test" ,Category=c};

            DatabaseFactory d = new DatabaseFactory();
            UnitOfWork u = new UnitOfWork(d);
            
            u.GetRepository<Product>().Add(p);
            u.Commit();
            Console.WriteLine("fin");
            Console.ReadKey();

        }
    }
}
