using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface ICateringCompanies_Service
    {
        bool Insert(CateringCompanies cateringCompanies);

        void Update(CateringCompanies cateringCompanies);

        List<CateringCompanies> GetAllCateringCompanies();

        CateringCompanies GetCateringCompanies(string Code);

    }
}
