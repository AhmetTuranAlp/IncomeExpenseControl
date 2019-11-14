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

        public enum ExpenseType
        {
            [Description("Tedarikçi")]
            Suppliers = 0,
            [Description("Fatura")]
            Invoice = 1,
            [Description("Personel")]
            Staff = 2,
            [Description("Araç")]
            Vehicle = 3,
            [Description("Banka")]
            Bank = 4
        }


        public enum InvoiceType
        {
            [Description("Su")]
            That = 0,
            [Description("Elektirik")]
            Electricity = 1,
            [Description("Doğalgaz")]
            NaturalGas = 2,
            [Description("İnternet")]
            Internet = 3,
            [Description("Diger")]
            Other = 4
        }

        public enum PaymentType : int
        {
            [Description("Nakit")]
            Cash = 1,
            [Description("Yemek Kartı")]
            FoodCard = 2,
            [Description("Kredi & Banka Kartı")]
            CreditCard = 3
        }

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
