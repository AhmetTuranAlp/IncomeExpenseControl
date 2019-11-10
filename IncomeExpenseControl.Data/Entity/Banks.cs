using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class Banks :Base
    {
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string Descriptions { get; set; }
    }
}
