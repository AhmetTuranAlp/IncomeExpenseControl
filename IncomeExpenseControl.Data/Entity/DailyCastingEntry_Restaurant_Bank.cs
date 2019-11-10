using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Data.Entity
{
    public class DailyCastingEntry_Restaurant_Bank : Base
    {
        public DailyCastingEntry_Restaurant_Bank()
        {
            Banks = new Banks();
            Price = 0;
            NumberOfPeople = 0;
            CastingDate = DateTime.Now;
        }

        public DateTime CastingDate { get; set; } //Döküm Tarihi
        public Banks Banks { get; set; }
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
