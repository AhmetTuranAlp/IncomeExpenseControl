using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IExpense_Suppliers_Service
    {
        bool Insert(Expense_Suppliers expense_Suppliers);

        bool Update(Expense_Suppliers expense_Suppliers);

        List<Expense_Suppliers> GetAllExpense_Suppliers();

        Expense_Suppliers GetExpense_Suppliers(DateTime ExpenseDate, string SupplierCode);

    }
}
