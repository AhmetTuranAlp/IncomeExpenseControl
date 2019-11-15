using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface IStaff_Service
    {
        bool Insert(Staff staff);

        bool Update(Staff staff);

        List<Staff> GetAllStaffs();
    }
}
