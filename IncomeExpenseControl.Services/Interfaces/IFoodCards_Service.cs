using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IFoodCards_Service
    {
        bool Insert(FoodCards foodCards);

        bool Update(FoodCards foodCards);

        List<FoodCards> GetAllFoodCards();

        FoodCards GetFoodCards(string Code);
    }
}
