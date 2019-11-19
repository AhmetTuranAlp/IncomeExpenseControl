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
    public partial class Definition_SupplierCompanies_Form : Form
    {
        public Definition_SupplierCompanies_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
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
                        MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
             
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDescriptions.Text = "";
        }
    }
}
