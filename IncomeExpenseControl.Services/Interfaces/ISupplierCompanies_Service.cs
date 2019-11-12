using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface ISupplierCompanies_Service
    {
        bool Insert(SupplierCompanies supplierCompanies);

        bool Update(SupplierCompanies supplierCompanies);

        List<SupplierCompanies> GetAllSupplierCompanies();

        SupplierCompanies GetSupplierCompanies(string Code);
    }
}
