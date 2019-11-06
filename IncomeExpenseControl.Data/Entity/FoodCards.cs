using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class FoodCards : Base
    {
        public FoodCards()
        {
            this.Name = "";
            this.Descriptions = "";
            this.CardCode = "";
        }

        [Column("Adı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Name { get; set; }

        [Column("Açıklama")]
        public string Descriptions { get; set; }

        [Column("Kard Kodu")]
        public string CardCode { get; set; }
    }
}
