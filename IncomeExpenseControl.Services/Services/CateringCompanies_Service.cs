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
    public class CateringCompanies_Service : ICateringCompanies_Service
    {
        private readonly IRepository<CateringCompanies> _cateringCompaniesRepo;
        private readonly IUnitofWork _uow;
        public CateringCompanies_Service(UnitofWork uow)
        {
            _uow = uow;
            _cateringCompaniesRepo = _uow.GetRepository<CateringCompanies>();
        }

        public List<CateringCompanies> GetAllCateringCompanies()
        {
            try
            {
                return _cateringCompaniesRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CateringCompanies GetCateringCompanies(string Code)
        {
            try
            {
                return _cateringCompaniesRepo.GetAll().FirstOrDefault(x => x.Status == Status.Active && x.Code == Code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(CateringCompanies cateringCompanies)
        {
            throw new NotImplementedException();
        }

        public void Update(CateringCompanies cateringCompanies)
        {
            throw new NotImplementedException();
        }
    }
}
