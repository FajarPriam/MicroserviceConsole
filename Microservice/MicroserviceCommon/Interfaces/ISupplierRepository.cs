﻿using MicroserviceDataAccess.Model;
using MicroserviceDataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceCommon.Interfaces
{
    public interface ISupplierRepository
    {
        bool Insert(SupplierParam supplierParam);
        bool Update(int? id, SupplierParam supplierParam);
        bool Delete(int? id);
        List<Supplier> Get();
        Supplier Get(int? id);
    }
}
