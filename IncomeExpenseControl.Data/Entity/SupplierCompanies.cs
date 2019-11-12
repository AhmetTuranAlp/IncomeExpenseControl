using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class SupplierCompanies : Base
    {
        public SupplierCompanies()
        {
            Name = "";
            Code = "";
            Descriptions = "";
        }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Descriptions { get; set; }
    }
}
