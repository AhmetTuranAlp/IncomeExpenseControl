using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class CateringFoodDelivery : Base
    {
        public CateringFoodDelivery()
        {
            this.Name = "";
            this.Descriptions = "";
            this.Price = 0;
            this.CompanyCode = "";
            this.NumberOfPeople = 0;
            this.ServiceDate = DateTime.Now;
        }

        [Column("Firma Adı")]
        public string Name { get; set; }

        [Column("Firma Kodu")]
        public string CompanyCode { get; set; }

        [Column("Açıklama")]
        public string Descriptions { get; set; }

        [Column("Servis Tarihi")]
        public DateTime ServiceDate { get; set; }

        [Column("Kişi Sayısı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public int NumberOfPeople { get; set; }

        private decimal _price;
        [Column("Fiyat")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Price
        {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        }
    }
}
