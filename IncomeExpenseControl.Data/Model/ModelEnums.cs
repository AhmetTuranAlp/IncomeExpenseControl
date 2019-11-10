using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class ModelEnums
    {
        public enum Status : int
        {
            [Description("Silindi")]
            Deleted = 0,
            [Description("Aktif")]
            Active = 1,
            [Description("Pasif")]
            Passive = 2,
            [Description("Yeni Kayıt")]
            NewRecord = 3
        }

        //public enum PaymentType : int
        //{
        //    [Description("Nakit")]
        //    Cash = 1,
        //    [Description("Yemek Kartı")]
        //    FoodCard = 2,
        //    [Description("Kredi & Banka Kartı")]
        //    CreditCard = 3
        //}

        //public enum RevenueType : int
        //{
        //    [Description("Catering")]
        //    Catering = 1,
        //    [Description("Restaurant")]
        //    Restaurant = 2,
        //    [Description("Şahsi Gelir")]
        //    Personal = 3
        //}
    }
}
