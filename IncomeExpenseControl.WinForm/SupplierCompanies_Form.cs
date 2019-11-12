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
    public partial class SupplierCompanies_Form : Form
    {
        public SupplierCompanies_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                Tools tools = new Tools();
                UnitofWork unitofWork = new UnitofWork(ctx);
                SupplierCompanies_Service supplierCompanies_Service = new SupplierCompanies_Service(unitofWork);
                SupplierCompanies supplierCompanies = new SupplierCompanies
                {
                    Name = txtName.Text,
                    Descriptions = txtDescriptions.Text,
                    Code = tools.CreateCode()
                };
                if (supplierCompanies_Service.Insert(supplierCompanies))
                {
                    txtName.Text = "";
                    txtDescriptions.Text = "";
                    MessageBox.Show("İşlem Başarılı");
                }
                else
                {
                    MessageBox.Show("Hata Oluştu");
                }
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.");
            }
        }
    }
}
