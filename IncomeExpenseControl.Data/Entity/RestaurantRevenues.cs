using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Data.Entity
{
    public class RestaurantRevenues : Base
    {
        public RestaurantRevenues()
        {
            this.PaymentType = PaymentType.Cash;
            this.CreditCards = new CreditCards();
            this.FoodCards = new FoodCards();
            this.Price = 0;
            this.NumberOfPeople = 0;
            this.RevenuesDate = DateTime.Now;
        }

        public PaymentType PaymentType { get; set; }

        public CreditCards CreditCards { get; set; }

        public FoodCards FoodCards { get; set; }

        private decimal _price;
        [Column("Fiyat")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        }

        [Column("Kişi Sayısı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public int NumberOfPeople { get; set; }

        [Column("Gelir Günü")]
        public DateTime RevenuesDate { get; set; }

    }
}
