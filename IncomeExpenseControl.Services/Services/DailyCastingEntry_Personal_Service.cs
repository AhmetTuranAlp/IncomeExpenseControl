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
    public class DailyCastingEntry_Personal_Service : IDailyCastingEntry_Personal_Service
    {
        private readonly IRepository<DailyCastingEntry_Personal> _personalPaymentRepo;
        private readonly IUnitofWork _uow;
        public DailyCastingEntry_Personal_Service(UnitofWork uow)
        {
            _uow = uow;
            _personalPaymentRepo = _uow.GetRepository<DailyCastingEntry_Personal>();
        }

        public List<DailyCastingEntry_Personal> GetAllDailyCastingEntry_Personal()
        {
            try
            {
                return _personalPaymentRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(c => c.CastingDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(DailyCastingEntry_Personal personalPayment)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<DailyCastingEntry_Personal>(personalPayment);
                newEntity.Status = Status.Active;
                _personalPaymentRepo.Insert(newEntity);
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
