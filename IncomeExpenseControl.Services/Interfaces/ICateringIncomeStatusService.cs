using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface ICateringIncomeStatusService
    {
        CateringIncomeStatus GetCateringIncomeStatus(string code, DateTime dateTime);

        List<CateringIncomeStatus> GetAllCateringIncomeStatus();

        bool Insert(CateringIncomeStatus cateringIncomeStatus);

        void Update(CateringIncomeStatus cateringIncomeStatus);

        void Delete(int Id);
    }
}
