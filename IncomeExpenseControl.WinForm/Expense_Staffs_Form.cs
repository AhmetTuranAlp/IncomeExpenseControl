using IncomeExpenseControl.Common;
using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.Data.Entity;
using IncomeExpenseControl.Data.Model;
using IncomeExpenseControl.DataAccess.Base.UnitofWork;
using IncomeExpenseControl.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.WinForm
{
    public partial class Expense_Staffs_Form : Form
    {
        public Expense_Staffs_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        EnumHelper enumHelper = new EnumHelper();
        private void Expense_Staffs_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            Staff_Service staff_Service = new Staff_Service(unitofWork);

            List<Staff> staffsList = new List<Staff>();
            staffsList.Add(new Staff() { Id = 0, FullName = "Personel Seçiniz..." });
            staffsList.AddRange(staff_Service.GetAllStaffs());

            cmbStaffs.DataSource = staffsList;
            cmbStaffs.DisplayMember = "FullName";
            cmbStaffs.ValueMember = "Id";




            List<SelectListItem> expense_StaffsList = new List<SelectListItem>();
            expense_StaffsList.Add(new SelectListItem() { Value = "", Text = "Gider Tipi..." });
            expense_StaffsList.AddRange(enumHelper.GetEnumListWithDescription(typeof(StaffExpenseType)));

            cmbStaffExpense.DataSource = expense_StaffsList;
            cmbStaffExpense.DisplayMember = "Text";
            cmbStaffExpense.ValueMember = "Value";
        }
    }
}
