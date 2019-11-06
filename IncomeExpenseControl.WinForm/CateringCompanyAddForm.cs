using IncomeExpenseControl.Common;
using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.Data.Entity;
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

namespace IncomeExpenseControl.WinForm
{
    public partial class CateringCompanyAddForm : Form
    {
        public CateringCompanyAddForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Tools tools = new Tools();

            IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanyService companyService = new CateringCompanyService(unitofWork);
            CateringCompany cateringCompany = new CateringCompany();
            cateringCompany.Name = txtName.Text;
            cateringCompany.Descriptions = txtDescriptions.Text;
            cateringCompany.CompanyCode = tools.CreateCode();
            if (companyService.Insert(cateringCompany))
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Hata Oluştu");
            }
        }
    }
}
