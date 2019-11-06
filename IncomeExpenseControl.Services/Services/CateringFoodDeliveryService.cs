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
    public class CateringFoodDeliveryService : ICateringFoodDeliveryService
    {
        private readonly IRepository<CateringFoodDelivery> _cateringFoodDeliveryRepo;
        private readonly IUnitofWork _uow;

        public CateringFoodDeliveryService(UnitofWork uow)
        {
            _uow = uow;
            _cateringFoodDeliveryRepo = _uow.GetRepository<CateringFoodDelivery>();
        }
        public void Delete(int Id)
        {
            try
            {
                var entity = _cateringFoodDeliveryRepo.Find(Id);
                entity.Status = Status.Deleted;
                _cateringFoodDeliveryRepo.Update(entity);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CateringFoodDelivery> GetAllCateringFoodDelivery()
        {
            try
            {
                return _cateringFoodDeliveryRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CateringFoodDelivery GetCateringFoodDelivery(int Id)
        {
            try
            {
                return _cateringFoodDeliveryRepo.GetAll().FirstOrDefault(x => x.Id == Id && x.Status == Status.Active);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(CateringFoodDelivery cateringFoodDelivery)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<CateringFoodDelivery>(cateringFoodDelivery);
                newEntity.Status = Status.Active;
                _cateringFoodDeliveryRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Update(CateringFoodDelivery cateringFoodDelivery)
        {
            try
            {
                var staffEntity = _cateringFoodDeliveryRepo.Find(cateringFoodDelivery.Id);
                AutoMapper.Mapper.DynamicMap(cateringFoodDelivery, staffEntity);
                _cateringFoodDeliveryRepo.Update(staffEntity);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
