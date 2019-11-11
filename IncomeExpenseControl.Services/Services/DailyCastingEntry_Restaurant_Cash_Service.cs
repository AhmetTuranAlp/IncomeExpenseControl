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
    public class DailyCastingEntry_Restaurant_Cash_Service : IDailyCastingEntry_Restaurant_Cash_Service
    {
        private readonly IRepository<DailyCastingEntry_Restaurant_Cash> _restaurantCashRepo;
        private readonly IUnitofWork _uow;
        public DailyCastingEntry_Restaurant_Cash_Service(UnitofWork uow)
        {
            _uow = uow;
            _restaurantCashRepo = _uow.GetRepository<DailyCastingEntry_Restaurant_Cash>();
        }

        public List<DailyCastingEntry_Restaurant_Cash> GetAllCateringPaymentCasting()
        {
            try
            {
                return _restaurantCashRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.CastingDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DailyCastingEntry_Restaurant_Cash GetCateringPaymentCasting(DateTime CastingDate)
        {
            try
            {
                return _restaurantCashRepo.GetAll().FirstOrDefault(x => x.CastingDate == CastingDate && x.Status == Status.Active );
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(DailyCastingEntry_Restaurant_Cash dailyCastingEntry_Restaurant_Cash)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<DailyCastingEntry_Restaurant_Cash>(dailyCastingEntry_Restaurant_Cash);
                newEntity.Status = Status.Active;
                _restaurantCashRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(DailyCastingEntry_Restaurant_Cash dailyCastingEntry_Restaurant_Cash)
        {
            try
            {
                var updateEntity = _restaurantCashRepo.Find(dailyCastingEntry_Restaurant_Cash.Id);
                AutoMapper.Mapper.DynamicMap(dailyCastingEntry_Restaurant_Cash, updateEntity);
                _restaurantCashRepo.Update(updateEntity);
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
