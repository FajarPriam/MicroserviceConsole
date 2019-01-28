using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroserviceDataAccess.Model;
using MicroserviceDataAccess.Param;
using MicroserviceCommon.Interfaces.Master;
using MicroserviceCommon.Interfaces;

namespace MicroserviceBissinesLogic.Service.Master
{
    public class SupplierService : ISupplierService
    {
        ISupplierRepository _supplierRepository = new SupplierRepository();

        bool status = false;
        public bool Delete(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            else if (id == ' ')
            {
                Console.WriteLine("Dont Insert Blank Caracter");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Delete(id);
                Console.WriteLine("Success");
            }
            return status;
        }

        public List<Supplier> Get()
        {
            //var get = _supplierRepository.Get.Where(x => x.IsDelete == false).ToList();
            //return get;
            return _supplierRepository.Get();
        }

        public Supplier Get(int? id)
        {
            var getSupplierId = _supplierRepository.Get(id);
            if (id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            /*else (id == ' ')
            {
                Console.WriteLine("Dont Insert Blank Caracter");
                Console.Read();
            }*/
            return getSupplierId;
            //return _supplierRepository.Get(id);
        }

        public bool Insert(SupplierParam supplierParam)
        {
            if (supplierParam == null)
            {
                Console.WriteLine("Insert Name");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Insert(supplierParam);
                Console.WriteLine("Success");
            }
            return status;
            //return _supplierRepository.Insert(supplierParam);
        }

        public bool Update(int? id, SupplierParam supplierParam)
        {
            if (id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            else if (id == ' ')
            {
                Console.WriteLine("Dont Insert Blank Caracter");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Update(id, supplierParam);
                Console.WriteLine("update Success");
            }
            return status;
            //return _supplierRepository.Update(id, supplierParam);
        }
    }
}
