using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroserviceDataAccess.Model;
using MicroserviceDataAccess.Param;

namespace MicroserviceCommon.Interfaces.Master
{
    public class SupplierRepository : ISupplierRepository
    {
        bool status = false;
        MyContext _context = new MyContext();
        public bool Delete(int? id)
        {
            var result = 0;
            Supplier supplier = Get(id);
            supplier.IsDelete = true;
            supplier.DeleteDate = DateTimeOffset.Now.LocalDateTime;
            result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Supplier> Get()
        {
            var get = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Supplier Get(int? id)
        {
            Supplier supplier = _context.Suppliers.Where(x => x.Id == id).SingleOrDefault();
            return supplier;
        }

        public bool Insert(SupplierParam supplierParam)
        {
            var result = 0;
            var supplier = new Supplier();
            supplier.Name = supplierParam.Name;
            supplier.CreateDate = DateTimeOffset.Now.LocalDateTime;
            _context.Suppliers.Add(supplier);
            result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(int? id, SupplierParam supplierParam)
        {
            var result = 0;
            var get = Get(id);
            get.Name = supplierParam.Name;
            get.CreateDate = DateTimeOffset.Now.LocalDateTime;
            result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
