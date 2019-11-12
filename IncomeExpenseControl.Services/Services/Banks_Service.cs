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
    public class Banks_Service : IBanks_Service
    {
        private readonly IRepository<Banks> _bankRepo;
        private readonly IUnitofWork _uow;
        public Banks_Service(UnitofWork uow)
        {
            _uow = uow;
            _bankRepo = _uow.GetRepository<Banks>();
        }

        public List<Banks> GetAllBanks()
        {
            try
            {
                return _bankRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Banks GetBanks(string Code)
        {
            try
            {
                return _bankRepo.GetAll().FirstOrDefault(x => x.Status == Status.Active && x.BankCode == Code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(Banks banks)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<Banks>(banks);
                newEntity.Status = Status.Active;
                _bankRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Banks banks)
        {
            try
            {
                var updateEntity = _bankRepo.Find(banks.Id);
                AutoMapper.Mapper.DynamicMap(banks, updateEntity);
                _bankRepo.Update(updateEntity);
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
