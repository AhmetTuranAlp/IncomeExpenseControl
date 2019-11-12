using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IDailyCastingEntry_Restaurant_Bank_Service
    {
        bool Insert(DailyCastingEntry_Restaurant_Bank dailyCastingEntry_Restaurant_Bank);

        bool Update(DailyCastingEntry_Restaurant_Bank dailyCastingEntry_Restaurant_Bank);

        List<DailyCastingEntry_Restaurant_Bank> GetAllRestaurantBanksPaymentCasting();

        DailyCastingEntry_Restaurant_Bank GetRestaurantBanksPaymentCasting(DateTime CastingDate);
    }
}
