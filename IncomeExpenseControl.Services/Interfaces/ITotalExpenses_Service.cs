using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface ITotalExpenses_Service
    {
        bool Insert(TotalExpenses totalExpenses);

        bool Update(TotalExpenses totalExpenses);

        TotalExpenses GetTotalExpenses(DateTime expenseDate, ExpenseType expenseType);

        List<TotalExpenses> GetAllTotalExpenses();
    }
}
