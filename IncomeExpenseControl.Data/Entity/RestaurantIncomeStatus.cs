using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Data.Entity
{
    public class RestaurantIncomeStatus : Base
    {
        public RestaurantIncomeStatus()
        {
            this.TotalReceived = 0;
            this.TotalReceivables = 0;
            this.CreditCards = new CreditCards();
            this.FoodCards = new FoodCards();
        }

        public PaymentType PaymentType { get; set; }

        public CreditCards CreditCards { get; set; }

        public FoodCards FoodCards { get; set; }

        [Column("İlgili Gün")]
        public DateTime RelatedDay { get; set; }

        private decimal _totalReceivables;
        [Column("Toplam Alınacak Tutar")]
        public decimal TotalReceivables
        {
            get { return _totalReceivables; }
            set { _totalReceivables = Math.Round(value, 2); }
        }

        private decimal _totalReceived;
        [Column("Toplam Alınan Tutar")]
        public decimal TotalReceived
        {
            get { return _totalReceived; }
            set { _totalReceived = Math.Round(value, 2); }
        }

        private decimal _remainingAmount;
        [Column("Kalan Miktar")]
        public decimal RemainingAmount
        {
            get
            {
                if (this.TotalReceivables > 0)
                {
                    _remainingAmount = this.TotalReceived > 0 ? _remainingAmount = this.TotalReceivables - this.TotalReceived : 0;
                }
                return _remainingAmount;
            }
            set
            {
                _remainingAmount = Math.Round(value, 2);
            }
        }
    }
}
