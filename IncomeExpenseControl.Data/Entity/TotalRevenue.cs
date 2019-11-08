using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Data.Entity
{
    public class TotalRevenue : Base
    {
        public RevenueType RevenueType { get; set; }
        public DateTime RevenueDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
