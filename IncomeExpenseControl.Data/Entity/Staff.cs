using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class Staff : Base
    {
        public Staff()
        {
            TimetoWork = DateTime.Now;
            Salary = 0;
            FullName = "";
        }
        public string FullName { get; set; }
        public decimal Salary { get; set; }
        public DateTime TimetoWork { get; set; }
    }
}
