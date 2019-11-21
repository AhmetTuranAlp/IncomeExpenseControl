using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IDailyCastingEntry_Catering_Service
    {
        bool Insert(DailyCastingEntry_Catering cateringPayment);

        bool Update(DailyCastingEntry_Catering cateringPayment);

        List<DailyCastingEntry_Catering> GetAllCateringPaymentCasting();

        DailyCastingEntry_Catering GetCateringPaymentCasting(DateTime CastingDate, string CateringCode);
    }
}
