using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class CateringIncomeStatus : Base
    {
        public CateringIncomeStatus()
        {
            this.Name = "";
            this.CompanyCode = "";
            this.TotalReceived = 0;
            this.TotalReceivables = 0;
            this.RelatedMount = DateTime.Now.Month;
        }

        [Column("Firma Adı")]
        public string Name { get; set; }

        [Column("Firma Kodu")]
        public string CompanyCode { get; set; }

        [Column("İlgili Ay")]
        public int RelatedMount { get; set; }

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
