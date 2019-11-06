using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class CateringCompany :Base
    {
        public CateringCompany()
        {
            this.Name = "";
            this.Descriptions = "";
            this.CompanyCode = "";
        }

        [Column("Firma Adı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Name { get; set; }

        [Column("Açıklama")]
        public string Descriptions { get; set; }

        [Column("Firma Kodu")]
        public string CompanyCode { get; set; }
    }
}
