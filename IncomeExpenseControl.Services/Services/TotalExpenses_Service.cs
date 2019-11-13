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
    public class TotalExpenses_Service : ITotalExpenses_Service
    {
        private readonly IRepository<TotalExpenses> _totalExpensesRepo;
        private readonly IUnitofWork _uow;
        public TotalExpenses_Service(UnitofWork uow)
        {
            _uow = uow;
            _totalExpensesRepo = _uow.GetRepository<TotalExpenses>();
        }

        public List<TotalExpenses> GetAllTotalExpenses()
        {
            try
            {
                return _totalExpensesRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.ExpenseDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TotalExpenses GetTotalExpenses(DateTime expenseDate, ModelEnums.ExpenseType expenseType)
        {
            try
            {
                return _totalExpensesRepo.GetAll().FirstOrDefault(x => x.ExpenseDate == expenseDate && x.Status == Status.Active && x.ExpenseType == expenseType);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(TotalExpenses totalExpenses)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<TotalExpenses>(totalExpenses);
                newEntity.Status = Status.Active;
                _totalExpensesRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(TotalExpenses totalExpenses)
        {
            try
            {
                var updateEntity = _totalExpensesRepo.Find(totalExpenses.Id);
                AutoMapper.Mapper.DynamicMap(totalExpenses, updateEntity);
                _totalExpensesRepo.Update(updateEntity);
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
