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
    public class Expense_Vehicle_Service : IExpense_Vehicle_Service
    {
        private readonly IRepository<Expense_Vehicle> _expenseVehicleRepo;
        private readonly IUnitofWork _uow;
        public Expense_Vehicle_Service(UnitofWork uow)
        {
            _uow = uow;
            _expenseVehicleRepo = _uow.GetRepository<Expense_Vehicle>();
        }

        public List<Expense_Vehicle> GetAllExpense_Vehicle()
        {
            try
            {
                return _expenseVehicleRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.ExpenseDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Expense_Vehicle> GetExpense_Vehicle(DateTime ExpenseDate)
        {
            try
            {
                return _expenseVehicleRepo.GetAll().Where(x => x.Status == Status.Active && x.ExpenseDate == ExpenseDate).OrderBy(c => c.ExpenseDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(Expense_Vehicle expense_Vehicle)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<Expense_Vehicle>(expense_Vehicle);
                newEntity.Status = Status.Active;
                _expenseVehicleRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Expense_Vehicle expense_Vehicle)
        {
            try
            {
                var updateEntity = _expenseVehicleRepo.Find(expense_Vehicle.Id);
                AutoMapper.Mapper.DynamicMap(expense_Vehicle, updateEntity);
                _expenseVehicleRepo.Update(updateEntity);
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
