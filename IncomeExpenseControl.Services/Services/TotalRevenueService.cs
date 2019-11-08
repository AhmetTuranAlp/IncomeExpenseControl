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
    public class TotalRevenueService : ITotalRevenueService
    {
        private readonly IRepository<TotalRevenue> _totalRevenueRepo;
        private readonly IUnitofWork _uow;

        public TotalRevenueService(UnitofWork uow)
        {
            _uow = uow;
            _totalRevenueRepo = _uow.GetRepository<TotalRevenue>();
        }

        public decimal GetRevenueDayTotalPrice(DateTime RevenueDay)
        {
            try
            {
                return _totalRevenueRepo.GetAll().FirstOrDefault(x => x.Status == Status.Active && x.RevenueDate.Day == RevenueDay.Day).TotalPrice;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal GetRevenueeMonthTotalPrice(DateTime RevenueMonth)
        {
            try
            {
                decimal _totalPrice = 0;
                List<TotalRevenue> totalRevenues = _totalRevenueRepo.GetAll().Where(x => x.Status == Status.Active && x.RevenueDate.Month == RevenueMonth.Month).ToList();
                if (totalRevenues.Count > 0)
                {
                    totalRevenues.ForEach(x =>
                    {
                        _totalPrice += x.TotalPrice;
                    });
                }
                return _totalPrice;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public List<TotalRevenue> GetTotalRevenueDay(DateTime RevenueDay)
        {
            try
            {
                return _totalRevenueRepo.GetAll().Where(x => x.Status == Status.Active && x.RevenueDate.Day == RevenueDay.Day).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public bool Insert(TotalRevenue totalRevenue)
        {
            try
            {
                var totalRevenueEntity = AutoMapper.Mapper.DynamicMap<TotalRevenue>(totalRevenue);
                totalRevenueEntity.Status = Status.Active;
                _totalRevenueRepo.Insert(totalRevenueEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public TotalRevenue GetSelectedTotalRevenueDay(RevenueType RevenueType, DateTime RevenueDay)
        {
            try
            {
                return _totalRevenueRepo.GetAll().FirstOrDefault(x => x.Status == Status.Active && x.RevenueDate.Day == RevenueDay.Day && x.RevenueType == RevenueType);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TotalRevenue> GetSelectedTotalRevenueMonth(RevenueType RevenueType, DateTime RevenueMonth)
        {
            try
            {
                return _totalRevenueRepo.GetAll().Where(x => x.Status == Status.Active && x.RevenueDate.Month == RevenueMonth.Month && x.RevenueType == RevenueType).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TotalRevenue> GetTotalRevenueMonth(DateTime RevenueMonth)
        {
            try
            {
                return _totalRevenueRepo.GetAll().Where(x => x.Status == Status.Active && x.RevenueDate.Month == RevenueMonth.Month).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public bool Update(TotalRevenue totalRevenue)
        {
            try
            {
                var totalRevenueEntity = _totalRevenueRepo.Find(totalRevenue.Id);
                AutoMapper.Mapper.DynamicMap(totalRevenue, totalRevenueEntity);
                _totalRevenueRepo.Update(totalRevenueEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
