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
    public class FoodCards_Service : IFoodCards_Service
    {
        private readonly IRepository<FoodCards> _foodCardRepo;
        private readonly IUnitofWork _uow;
        public FoodCards_Service(UnitofWork uow)
        {
            _uow = uow;
            _foodCardRepo = _uow.GetRepository<FoodCards>();
        }

        public List<FoodCards> GetAllFoodCards()
        {
            try
            {
                return _foodCardRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public FoodCards GetFoodCards(string Code)
        {
            try
            {
                return _foodCardRepo.GetAll().FirstOrDefault(x => x.Status == Status.Active && x.Code == Code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(FoodCards foodCards)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<FoodCards>(foodCards);
                newEntity.Status = Status.Active;
                _foodCardRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(FoodCards foodCards)
        {
            try
            {
                var updateEntity = _foodCardRepo.Find(foodCards.Id);
                AutoMapper.Mapper.DynamicMap(foodCards, updateEntity);
                _foodCardRepo.Update(updateEntity);
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
