using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Data.Model
{
    public class RestaurantRevenueVM
    {
        public DateTime CastingDate { get; set; } //Döküm Tarihi
        public string PaymentType { get; set; }
        public string Name { get; set; }
        public int NumberOfPeople { get; set; } //Kişi Sayısı

        private decimal _price;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        } //Fiyat
    }
}
