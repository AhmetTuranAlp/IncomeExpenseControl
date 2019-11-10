using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class DailyCastingEntry_Personal : Base
    {
        public DailyCastingEntry_Personal()
        {
            Descriptions = "";
            Price = 0;
            CastingDate = DateTime.Now;
        }
        public DateTime CastingDate { get; set; } //Döküm Tarihi

        private decimal _price;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        } //Fiyat
        public string Descriptions { get; set; }
    }
}
