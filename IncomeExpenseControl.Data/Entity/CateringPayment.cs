using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class CateringPayment : Base
    {
        public CateringPayment()
        {
            this.Name = "";
            this.Descriptions = "";
            this.CompanyCode = "";
            this.PaymentDate = DateTime.Now;
            this.Price = 0;
            this.InvoiceCut = false;
        }

        [Column("Firma Adı")]
        public string Name { get; set; }

        [Column("Firma Kodu")]
        public string CompanyCode { get; set; }

        [Column("Açıklama")]
        public string Descriptions { get; set; }

        [Column("Ödeme Tarihi")]
        public DateTime PaymentDate { get; set; }

        private decimal _price;
        [Column("Fiyat")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        }

        [Column("Fatura Kesimi")]
        public bool InvoiceCut { get; set; }
    }
}
