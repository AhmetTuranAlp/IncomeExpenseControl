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
    public class DailyCastingEntry_Restaurant_Food_Service : IDailyCastingEntry_Restaurant_Food_Service
    {
        private readonly IRepository<DailyCastingEntry_Restaurant_Food> _restaurantFoodRepo;
        private readonly IUnitofWork _uow;
        public DailyCastingEntry_Restaurant_Food_Service(UnitofWork uow)
        {
            _uow = uow;
            _restaurantFoodRepo = _uow.GetRepository<DailyCastingEntry_Restaurant_Food>();
        }

        public List<DailyCastingEntry_Restaurant_Food> GetAllRestaurantFoodPaymentCasting()
        {
            try
            {
                return _restaurantFoodRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.CastingDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DailyCastingEntry_Restaurant_Food GetRestaurantFoodPaymentCasting(DateTime CastingDate)
        {
            try
            {
                return _restaurantFoodRepo.GetAll().FirstOrDefault(x => x.CastingDate == CastingDate && x.Status == Status.Active);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(DailyCastingEntry_Restaurant_Food dailyCastingEntry_Restaurant_Food)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<DailyCastingEntry_Restaurant_Food>(dailyCastingEntry_Restaurant_Food);
                newEntity.Status = Status.Active;
                _restaurantFoodRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(DailyCastingEntry_Restaurant_Food dailyCastingEntry_Restaurant_Food)
        {
            try
            {
                var updateEntity = _restaurantFoodRepo.Find(dailyCastingEntry_Restaurant_Food.Id);
                AutoMapper.Mapper.DynamicMap(dailyCastingEntry_Restaurant_Food, updateEntity);
                _restaurantFoodRepo.Update(updateEntity);
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
