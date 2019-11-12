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
    public class DailyCastingEntry_TotalRevenue_Service : IDailyCastingEntry_TotalRevenue_Service
    {
        private readonly IRepository<DailyCastingEntry_TotalRevenue> _totalRevenueRepo;
        private readonly IUnitofWork _uow;
        public DailyCastingEntry_TotalRevenue_Service(UnitofWork uow)
        {
            _uow = uow;
            _totalRevenueRepo = _uow.GetRepository<DailyCastingEntry_TotalRevenue>();
        }

        public List<DailyCastingEntry_TotalRevenue> GetAllTotalRevenue()
        {
            try
            {
                return _totalRevenueRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DailyCastingEntry_TotalRevenue GetTotalRevenue(DateTime CastingDate)
        {
            try
            {
                return _totalRevenueRepo.GetAll().FirstOrDefault(x => x.CastingDate == CastingDate && x.Status == Status.Active);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(DailyCastingEntry_TotalRevenue DailyCastingEntry_TotalRevenue)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<DailyCastingEntry_TotalRevenue>(DailyCastingEntry_TotalRevenue);
                newEntity.Status = Status.Active;
                _totalRevenueRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(DailyCastingEntry_TotalRevenue DailyCastingEntry_TotalRevenue)
        {
            try
            {
                var updateEntity = _totalRevenueRepo.Find(DailyCastingEntry_TotalRevenue.Id);
                AutoMapper.Mapper.DynamicMap(DailyCastingEntry_TotalRevenue, updateEntity);
                _totalRevenueRepo.Update(updateEntity);
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
