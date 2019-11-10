using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class DailyCastingEntry_Restaurant_Cash : Base
    {
        public DailyCastingEntry_Restaurant_Cash()
        {
            NumberOfPeople = 0;
            Price = 0;
            CastingDate = DateTime.Now;
        }

        public DateTime CastingDate { get; set; }  //Döküm Tarihi
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
