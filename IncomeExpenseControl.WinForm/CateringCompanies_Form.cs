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
    public partial class CateringCompanies_Form : Form
    {
        public CateringCompanies_Form()
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
                    CateringCompanies_Service cateringCompanies_Service = new CateringCompanies_Service(unitofWork);
                    CateringCompanies cateringCompanies = new CateringCompanies();
                    cateringCompanies.Name = txtName.Text;
                    cateringCompanies.Descriptions = txtDescriptions.Text;
                    cateringCompanies.Code = tools.CreateCode();
                    if (cateringCompanies_Service.Insert(cateringCompanies))
                    {
                        txtName.Text = "";
                        txtDescriptions.Text = "";
                        MessageBox.Show("İşlem Başarılı", "");
                    }
                    else
                    {
                        MessageBox.Show("Hata Oluştu", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDescriptions.Text = "";
        }
    }
}
