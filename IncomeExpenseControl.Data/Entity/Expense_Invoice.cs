using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Data.Entity
{
    public class Expense_Invoice : Base
    {
        public Expense_Invoice()
        {
            ExpenseDate = DateTime.Now;
            Descriptions = "";
            Price = 0;
        }
        public DateTime ExpenseDate { get; set; }
        public string InvoiceType { get; set; }
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
