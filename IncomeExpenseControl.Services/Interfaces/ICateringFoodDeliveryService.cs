using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface ICateringFoodDeliveryService
    {
        CateringFoodDelivery GetCateringFoodDelivery(string code, DateTime ServiceDate);

        List<CateringFoodDelivery> GetAllCateringFoodDelivery();

        bool Insert(CateringFoodDelivery cateringFoodDelivery);

        void Update(CateringFoodDelivery cateringFoodDelivery);

        void Delete(int Id);
    }
}
