﻿using System;
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
            BankName = "";
            BankCode = "";
            Price = 0;
            NumberOfPeople = 0;
            CastingDate = DateTime.Now;
        }

        public DateTime CastingDate { get; set; } //Döküm Tarihi
        public int NumberOfPeople { get; set; } //Kişi Sayısı

        public string BankName { get; set; }
        public string BankCode { get; set; }

        private decimal _price;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        } //Fiyat
        
    }
}
