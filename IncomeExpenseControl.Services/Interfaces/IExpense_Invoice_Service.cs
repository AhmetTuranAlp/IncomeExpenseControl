using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IExpense_Invoice_Service
    {
        bool Insert(Expense_Invoice expense_Invoice);

        bool Update(Expense_Invoice expense_Invoice);

        List<Expense_Invoice> GetAllExpense_Invoice();

        List<Expense_Invoice> GetExpense_Invoice(DateTime ExpenseDate);
    }
}
