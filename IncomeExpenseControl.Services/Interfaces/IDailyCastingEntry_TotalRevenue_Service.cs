using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IDailyCastingEntry_TotalRevenue_Service
    {
        bool Insert(DailyCastingEntry_TotalRevenue DailyCastingEntry_TotalRevenue);

        bool Update(DailyCastingEntry_TotalRevenue DailyCastingEntry_TotalRevenue);

        DailyCastingEntry_TotalRevenue GetTotalRevenue(DateTime CastingDate);

        List<DailyCastingEntry_TotalRevenue> GetAllTotalRevenue();

    }
}
