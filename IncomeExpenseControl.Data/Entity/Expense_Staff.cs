﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Data.Entity
{
    public class Expense_Staff : Base
    {
        public DateTime ExpenseDate { get; set; }

        public string FullName { get; set; }

        public string StaffExpenseType { get; set; }

        private decimal _price;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        } //Fiyat
    }
}