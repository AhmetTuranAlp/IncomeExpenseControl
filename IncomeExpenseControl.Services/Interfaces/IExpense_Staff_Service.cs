using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IExpense_Staff_Service
    {
        bool Insert(Expense_Staff expense_Staff);

        bool Update(Expense_Staff expense_Staff);

        List<Expense_Staff> GetAllExpense_Staff();

        Expense_Staff GetExpense_Staff(DateTime ExpenseDate, string FullName);
    }
}
