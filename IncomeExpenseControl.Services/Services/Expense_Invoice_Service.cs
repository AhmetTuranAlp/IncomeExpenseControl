using IncomeExpenseControl.Data.Entity;
using IncomeExpenseControl.DataAccess.Abstract.Repositories;
using IncomeExpenseControl.DataAccess.Abstract.UnitofWork;
using IncomeExpenseControl.DataAccess.Base.UnitofWork;
using IncomeExpenseControl.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Services.Services
{
    public class Expense_Invoice_Service : IExpense_Invoice_Service
    {
        private readonly IRepository<Expense_Invoice> _expenseInvoiceRepo;
        private readonly IUnitofWork _uow;
        public Expense_Invoice_Service(UnitofWork uow)
        {
            _uow = uow;
            _expenseInvoiceRepo = _uow.GetRepository<Expense_Invoice>();
        }

        public List<Expense_Invoice> GetAllExpense_Invoice()
        {
            try
            {
                return _expenseInvoiceRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.ExpenseDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Expense_Invoice> GetExpense_Invoice(DateTime ExpenseDate)
        {
            try
            {
                return _expenseInvoiceRepo.GetAll().Where(x => x.Status == Status.Active && x.ExpenseDate == ExpenseDate).OrderBy(c => c.ExpenseDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(Expense_Invoice expense_Invoice)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<Expense_Invoice>(expense_Invoice);
                newEntity.Status = Status.Active;
                _expenseInvoiceRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Expense_Invoice expense_Invoice)
        {
            try
            {
                var updateEntity = _expenseInvoiceRepo.Find(expense_Invoice.Id);
                AutoMapper.Mapper.DynamicMap(expense_Invoice, updateEntity);
                _expenseInvoiceRepo.Update(updateEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
