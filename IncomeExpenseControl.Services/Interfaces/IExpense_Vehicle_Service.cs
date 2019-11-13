using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IExpense_Vehicle_Service
    {
        bool Insert(Expense_Vehicle expense_Vehicle);

        bool Update(Expense_Vehicle expense_Vehicle);

        List<Expense_Vehicle> GetAllExpense_Vehicle();

        List<Expense_Vehicle> GetExpense_Vehicle(DateTime ExpenseDate);
    }
}
