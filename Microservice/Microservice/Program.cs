using Microservice.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice
{
    class Program
    {
        static void Main(string[] args)
        {
            SupplierController callSupplier = new SupplierController();

            Console.WriteLine("=========== Manage Data ============");
            Console.WriteLine("1. Supplier");
            Console.WriteLine("====================================");
            Console.Write("Going to : ");
            int chance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("====================================");
            if (chance == 1)
            {
                callSupplier.ManageSupplier();
            }
            else
            {
                Console.WriteLine("Wrong Number");
                Console.Read();
            }
        }
    }
}
