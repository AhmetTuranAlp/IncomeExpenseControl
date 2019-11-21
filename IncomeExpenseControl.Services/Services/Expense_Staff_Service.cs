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
    public class Expense_Staff_Service : IExpense_Staff_Service
    {
        private readonly IRepository<Expense_Staff> _expenseStaffRepo;
        private readonly IUnitofWork _uow;
        public Expense_Staff_Service(UnitofWork uow)
        {
            _uow = uow;
            _expenseStaffRepo = _uow.GetRepository<Expense_Staff>();
        }


        public List<Expense_Staff> GetAllExpense_Staff()
        {
            try
            {
                return _expenseStaffRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.ExpenseDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Expense_Staff GetExpense_Staff(DateTime ExpenseDate, string FullName)
        {
            try
            {
                return _expenseStaffRepo.GetAll().FirstOrDefault(x => x.ExpenseDate == ExpenseDate && x.Status == Status.Active && x.FullName == FullName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(Expense_Staff expense_Staff)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<Expense_Staff>(expense_Staff);
                newEntity.Status = Status.Active;
                _expenseStaffRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Expense_Staff expense_Staff)
        {
            try
            {
                var updateEntity = _expenseStaffRepo.Find(expense_Staff.Id);
                AutoMapper.Mapper.DynamicMap(expense_Staff, updateEntity);
                _expenseStaffRepo.Update(updateEntity);
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
