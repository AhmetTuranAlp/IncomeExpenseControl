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
    public class DailyCastingEntry_Restaurant_Bank_Service : IDailyCastingEntry_Restaurant_Bank_Service
    {
        private readonly IRepository<DailyCastingEntry_Restaurant_Bank> _restaurantBankRepo;
        private readonly IUnitofWork _uow;
        public DailyCastingEntry_Restaurant_Bank_Service(UnitofWork uow)
        {
            _uow = uow;
            _restaurantBankRepo = _uow.GetRepository<DailyCastingEntry_Restaurant_Bank>();
        }

        public List<DailyCastingEntry_Restaurant_Bank> GetAllRestaurantBanksPaymentCasting()
        {
            try
            {
                return _restaurantBankRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.CastingDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DailyCastingEntry_Restaurant_Bank GetRestaurantBanksPaymentCasting(DateTime CastingDate)
        {
            try
            {
                return _restaurantBankRepo.GetAll().FirstOrDefault(x => x.CastingDate == CastingDate && x.Status == Status.Active);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(DailyCastingEntry_Restaurant_Bank dailyCastingEntry_Restaurant_Bank)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<DailyCastingEntry_Restaurant_Bank>(dailyCastingEntry_Restaurant_Bank);
                newEntity.Status = Status.Active;
                _restaurantBankRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(DailyCastingEntry_Restaurant_Bank dailyCastingEntry_Restaurant_Bank)
        {
            try
            {
                var updateEntity = _restaurantBankRepo.Find(dailyCastingEntry_Restaurant_Bank.Id);
                AutoMapper.Mapper.DynamicMap(dailyCastingEntry_Restaurant_Bank, updateEntity);
                _restaurantBankRepo.Update(updateEntity);
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
