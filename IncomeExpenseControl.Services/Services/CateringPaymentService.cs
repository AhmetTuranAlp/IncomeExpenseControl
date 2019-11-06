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
    public class CateringPaymentService : ICateringPaymentService
    {
        private readonly IRepository<CateringPayment> _cateringPaymentRepo;
        private readonly IUnitofWork _uow;
        public CateringPaymentService(UnitofWork uow)
        {
            _uow = uow;
            _cateringPaymentRepo = _uow.GetRepository<CateringPayment>();
        }
        public void Delete(int Id)
        {
            try
            {
                var entity = _cateringPaymentRepo.Find(Id);
                entity.Status = Status.Deleted;
                _cateringPaymentRepo.Update(entity);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CateringPayment> GetAllCateringPayment()
        {
            try
            {
                return _cateringPaymentRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CateringPayment GetCateringPayment(string code ,DateTime dateTime)
        {
            try
            {
                return _cateringPaymentRepo.GetAll().FirstOrDefault(x => x.CompanyCode == code && x.PaymentDate == dateTime && x.Status == Status.Active);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(CateringPayment cateringPayment)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<CateringPayment>(cateringPayment);
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

        public void Update(CateringPayment cateringPayment)
        {
            try
            {
                var cateringPaymentEntity = _cateringPaymentRepo.Find(cateringPayment.Id);
                AutoMapper.Mapper.DynamicMap(cateringPayment, cateringPaymentEntity);
                _cateringPaymentRepo.Update(cateringPaymentEntity);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
