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
    public class SupplierCompanies_Service : ISupplierCompanies_Service
    {
        private readonly IRepository<SupplierCompanies> _supplierCompaniesRepo;
        private readonly IUnitofWork _uow;
        public SupplierCompanies_Service(UnitofWork uow)
        {
            _uow = uow;
            _supplierCompaniesRepo = _uow.GetRepository<SupplierCompanies>();
        }

        public List<SupplierCompanies> GetAllSupplierCompanies()
        {
            try
            {
                return _supplierCompaniesRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SupplierCompanies GetSupplierCompanies(string Code)
        {
            try
            {
                return _supplierCompaniesRepo.GetAll().FirstOrDefault(x => x.Status == Status.Active && x.Code == Code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(SupplierCompanies supplierCompanies)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<SupplierCompanies>(supplierCompanies);
                newEntity.Status = Status.Active;
                _supplierCompaniesRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(SupplierCompanies supplierCompanies)
        {
            try
            {
                var updateEntity = _supplierCompaniesRepo.Find(supplierCompanies.Id);
                AutoMapper.Mapper.DynamicMap(supplierCompanies, updateEntity);
                _supplierCompaniesRepo.Update(updateEntity);
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
