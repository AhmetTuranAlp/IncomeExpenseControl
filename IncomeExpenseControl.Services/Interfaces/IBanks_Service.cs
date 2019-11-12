using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IBanks_Service
    {
        bool Insert(Banks banks);

        bool Update(Banks banks);

        List<Banks> GetAllBanks();

        Banks GetBanks(string Code);
    }
}
