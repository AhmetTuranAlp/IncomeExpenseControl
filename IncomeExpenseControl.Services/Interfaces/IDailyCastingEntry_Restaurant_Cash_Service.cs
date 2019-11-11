using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IDailyCastingEntry_Restaurant_Cash_Service
    {
        bool Insert(DailyCastingEntry_Restaurant_Cash dailyCastingEntry_Restaurant_Cash);

        bool Update(DailyCastingEntry_Restaurant_Cash dailyCastingEntry_Restaurant_Cash);

        List<DailyCastingEntry_Restaurant_Cash> GetAllCateringPaymentCasting();

        DailyCastingEntry_Restaurant_Cash GetCateringPaymentCasting(DateTime CastingDate);
    }
}
