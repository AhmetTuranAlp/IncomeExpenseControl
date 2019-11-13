using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class Expense_Vehicle : Base
    {
        public Expense_Vehicle()
        {
            ExpenseDate = DateTime.Now;
            Descriptions = "";
            Price = 0;
        }

        public DateTime ExpenseDate { get; set; }
        public string Descriptions { get; set; }

        private decimal _price;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        } //Fiyat
    }
}
