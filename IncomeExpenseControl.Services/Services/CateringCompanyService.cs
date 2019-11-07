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
    public class CateringCompanyService : ICateringCompanyService
    {
        private readonly IRepository<CateringCompany> _cateringCompanyRepo;
        private readonly IUnitofWork _uow;
        public CateringCompanyService(UnitofWork uow)
        {
            _uow = uow;
            _cateringCompanyRepo = _uow.GetRepository<CateringCompany>();
        }
        public void Delete(int Id)
        {
            try
            {
                var entity = _cateringCompanyRepo.Find(Id);
                entity.Status = Status.Deleted;
                _cateringCompanyRepo.Update(entity);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CateringCompany> GetAllCateringCompany()
        {
            try
            {
                return _cateringCompanyRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CateringCompany GetCateringCompany(int Id)
        {
            try
            {
                return _cateringCompanyRepo.GetAll().FirstOrDefault(x => x.Id == Id && x.Status == Status.Active);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CateringCompany GetCateringCompany(string CompanyCode)
        {
            try
            {
                return _cateringCompanyRepo.GetAll().FirstOrDefault(x => x.CompanyCode == CompanyCode && x.Status == Status.Active);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(CateringCompany cateringCompany)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<CateringCompany>(cateringCompany);
                newEntity.Status = Status.Active;
                _cateringCompanyRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Update(CateringCompany cateringCompany)
        {
            try
            {
                var staffEntity = _cateringCompanyRepo.Find(cateringCompany.Id);
                AutoMapper.Mapper.DynamicMap(cateringCompany, staffEntity);
                _cateringCompanyRepo.Update(staffEntity);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
