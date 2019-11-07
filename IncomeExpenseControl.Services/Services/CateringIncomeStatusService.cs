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
    public class CateringIncomeStatusService : ICateringIncomeStatusService
    {
        private readonly IRepository<CateringIncomeStatus> _cateringIncomeStatusRepo;
        private readonly IUnitofWork _uow;
        public CateringIncomeStatusService(UnitofWork uow)
        {
            _uow = uow;
            _cateringIncomeStatusRepo = _uow.GetRepository<CateringIncomeStatus>();
        }

        public int Count()
        {
            try
            {
                return _cateringIncomeStatusRepo.GetAll().Where(x => x.Status == Status.Active).ToList().Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int Id)
        {
            try
            {
                var entity = _cateringIncomeStatusRepo.Find(Id);
                entity.Status = Status.Deleted;
                _cateringIncomeStatusRepo.Update(entity);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CateringIncomeStatus> GetAllCateringIncomeStatus()
        {
            try
            {
                return _cateringIncomeStatusRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CateringIncomeStatus GetCateringIncomeStatus(string code, DateTime dateTime)
        {
            try
            {
                if (_cateringIncomeStatusRepo.GetAll().Count() > 0)
                {
                    return _cateringIncomeStatusRepo.GetAll().FirstOrDefault(x => x.CompanyCode == code && x.RelatedMount == dateTime.Month && x.Status == Status.Active);
                }
                else
                {
                    return new CateringIncomeStatus();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(CateringIncomeStatus cateringIncomeStatus)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<CateringIncomeStatus>(cateringIncomeStatus);
                newEntity.Status = Status.Active;
                _cateringIncomeStatusRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Update(CateringIncomeStatus cateringIncomeStatus)
        {
            try
            {
                var staffEntity = _cateringIncomeStatusRepo.Find(cateringIncomeStatus.Id);
                AutoMapper.Mapper.DynamicMap(cateringIncomeStatus, staffEntity);
                _cateringIncomeStatusRepo.Update(staffEntity);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
