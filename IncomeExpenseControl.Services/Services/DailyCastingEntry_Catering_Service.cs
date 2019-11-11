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
    public class DailyCastingEntry_Catering_Service : IDailyCastingEntry_Catering_Service
    {
        private readonly IRepository<DailyCastingEntry_Catering> _cateringPaymentRepo;
        private readonly IUnitofWork _uow;
        public DailyCastingEntry_Catering_Service(UnitofWork uow)
        {
            _uow = uow;
            _cateringPaymentRepo = _uow.GetRepository<DailyCastingEntry_Catering>();
        }

        public List<DailyCastingEntry_Catering> GetAllCateringPaymentCasting()
        {
            try
            {
                return _cateringPaymentRepo.GetAll().Where(x => x.Status == Status.Active ).OrderBy(c=>c.CastingDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DailyCastingEntry_Catering GetCateringPaymentCasting(DateTime CastingDate, string CateringCode)
        {
            try
            {
                return _cateringPaymentRepo.GetAll().FirstOrDefault(x => x.CastingDate == CastingDate && x.Status == Status.Active && x.CateringCompany.Code == CateringCode);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(DailyCastingEntry_Catering cateringPayment)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<DailyCastingEntry_Catering>(cateringPayment);
                newEntity.Status = Status.Active;
                _cateringPaymentRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(DailyCastingEntry_Catering cateringPayment)
        {
            try
            {
                var updateEntity = _cateringPaymentRepo.Find(cateringPayment.Id);
                AutoMapper.Mapper.DynamicMap(cateringPayment, updateEntity);
                _cateringPaymentRepo.Update(updateEntity);
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
