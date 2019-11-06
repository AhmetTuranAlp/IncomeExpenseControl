using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface ICateringCompanyService
    {
        CateringCompany GetCateringCompany(int Id);

        List<CateringCompany> GetAllCateringCompany();

        bool Insert(CateringCompany cateringCompany);

        void Update(CateringCompany cateringCompany);

        void Delete(int Id);
    }
}
