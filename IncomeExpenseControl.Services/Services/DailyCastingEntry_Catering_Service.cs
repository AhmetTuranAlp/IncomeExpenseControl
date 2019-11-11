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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update(DailyCastingEntry_Catering cateringPayment)
        {
            throw new NotImplementedException();
        }
    }
}
