using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class DailyCastingEntry_Catering : Base
    {
        public DailyCastingEntry_Catering()
        {
            CateringCompany = "";
            CompanyCode = "";            
            NumberOfPeople = 0;
            Price = 0;
            InvoiceCut = "";
            PaymentMade = "";
            CastingDate = DateTime.Now;
        }
        public DateTime CastingDate { get; set; } //Döküm Tarihi
        public string CateringCompany { get; set; } //İlgili Firma

        public int NumberOfPeople { get; set; } //Kişi Sayısı

        private decimal _price;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        } //Fiyat
        public string InvoiceCut { get; set; } //Fatura Kesildimi
        public string PaymentMade { get; set; } //Ödeme Yapıldımı
        public string CompanyCode { get; set; } //İlgili Firma

    }
}
