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
    public class Expense_Suppliers_Service : IExpense_Suppliers_Service
    {
        private readonly IRepository<Expense_Suppliers> _expenseSuppliersRepo;
        private readonly IUnitofWork _uow;
        public Expense_Suppliers_Service(UnitofWork uow)
        {
            _uow = uow;
            _expenseSuppliersRepo = _uow.GetRepository<Expense_Suppliers>();
        }

        public List<Expense_Suppliers> GetAllExpense_Suppliers()
        {
            try
            {
                return _expenseSuppliersRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.ExpenseDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Expense_Suppliers GetExpense_Suppliers(DateTime ExpenseDate, string SupplierCode)
        {
            try
            {
                return _expenseSuppliersRepo.GetAll().FirstOrDefault(x => x.ExpenseDate == ExpenseDate && x.Status == Status.Active && x.SupplierCode == SupplierCode);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(Expense_Suppliers expense_Suppliers)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<Expense_Suppliers>(expense_Suppliers);
                newEntity.Status = Status.Active;
                _expenseSuppliersRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Expense_Suppliers expense_Suppliers)
        {
            try
            {
                var updateEntity = _expenseSuppliersRepo.Find(expense_Suppliers.Id);
                AutoMapper.Mapper.DynamicMap(expense_Suppliers, updateEntity);
                _expenseSuppliersRepo.Update(updateEntity);
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
