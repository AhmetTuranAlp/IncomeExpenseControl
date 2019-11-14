using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class DailyCastingEntry_Restaurant_Food : Base
    {
        public DailyCastingEntry_Restaurant_Food()
        {
            NumberOfPeople = 0;
            Price = 0;
            CastingDate = DateTime.Now;
            FoodCardName = "";
            FoodCardCode = "";
        }

        public DateTime CastingDate { get; set; }

        public string FoodCardName { get; set; }
        public string FoodCardCode { get; set; }

        public int NumberOfPeople { get; set; } //Kişi Sayısı

        private decimal _price;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        } //Fiyat
        public bool PaymentMade { get; set; } //Ödeme Yapıldımı
    }
}
