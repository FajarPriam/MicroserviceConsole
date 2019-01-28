using MicroserviceBissinesLogic.Service;
using MicroserviceBissinesLogic.Service.Master;
using MicroserviceDataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Controller
{
    public class SupplierController
    {
        ISupplierService _supplierService = new SupplierService();

        public void ManageSupplier()
        {
            SupplierParam supplierparam = new SupplierParam();
            Console.WriteLine("========== Manage Supplier ==========");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Retrieve");
            Console.WriteLine("=====================================");
            Console.Write("Going to : ");
            int chance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================================");

            switch(chance)
            {
                case 1:
                    Console.Write("Insert Name of Supplier : ");
                    supplierparam.Name = Console.ReadLine();
                    _supplierService.Insert(supplierparam);
                    Console.Read();
                    break;
                case 2:
                    Console.Write("Insert Id :");
                    supplierparam.Id = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Insert New Name :");
                    supplierparam.Name = Console.ReadLine();
                    _supplierService.Update(supplierparam.Id, supplierparam);
                    Console.Read();
                    break;
                case 3:
                    Console.Write("Insert Id of Supplier : ");
                    supplierparam.Id = Convert.ToInt16(Console.ReadLine());
                    _supplierService.Delete(supplierparam.Id);
                    Console.Read();
                    break;
                case 4:
                    _supplierService.Get();
                    foreach (var tampilin in _supplierService.Get())
                    {
                            Console.WriteLine("============================");
                            Console.WriteLine("Name      : " + tampilin.Name);
                            Console.WriteLine("Join Date : " + tampilin.JoinDate);
                            Console.WriteLine("============================");
                    }
                    Console.Write("Total Supplier " + _supplierService.Get().Count);
                    Console.Read();
                    break;
                default:
                    Console.Write("Wrong Number");
                    break;
            }
        }
    }
}
