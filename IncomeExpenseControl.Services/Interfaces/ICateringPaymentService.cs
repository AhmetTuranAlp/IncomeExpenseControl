using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface ICateringPaymentService
    {
        CateringPayment GetCateringPayment(string code,DateTime dateTime);

        List<CateringPayment> GetAllCateringPayment();

        bool Insert(CateringPayment cateringPayment);

        void Update(CateringPayment cateringPayment);

        void Delete(int Id);
    }
}
