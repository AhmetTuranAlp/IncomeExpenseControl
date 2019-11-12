using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IDailyCastingEntry_Restaurant_Food_Service
    {
        bool Insert(DailyCastingEntry_Restaurant_Food dailyCastingEntry_Restaurant_Food);

        bool Update(DailyCastingEntry_Restaurant_Food dailyCastingEntry_Restaurant_Food);

        List<DailyCastingEntry_Restaurant_Food> GetAllRestaurantFoodPaymentCasting();

        DailyCastingEntry_Restaurant_Food GetRestaurantFoodPaymentCasting(DateTime CastingDate);
    }
}
