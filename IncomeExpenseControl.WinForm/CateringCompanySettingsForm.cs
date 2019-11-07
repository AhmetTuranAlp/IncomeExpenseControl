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
    public partial class CateringCompanySettingsForm : Form
    {
        public CateringCompanySettingsForm()
        {
            InitializeComponent();
        }
        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region Firma Ekleme İşlemi
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                Tools tools = new Tools();


                UnitofWork unitofWork = new UnitofWork(ctx);
                CateringCompanyService companyService = new CateringCompanyService(unitofWork);
                CateringCompany cateringCompany = new CateringCompany();
                cateringCompany.Name = txtName.Text;
                cateringCompany.Descriptions = txtDescriptions.Text;
                cateringCompany.CompanyCode = tools.CreateCode();
                if (companyService.Insert(cateringCompany))
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
            #endregion
        }

        private void CateringCompanySettingsForm_Load(object sender, EventArgs e)
        {
            #region Catering'ler Listelenmektedir.
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanyService companyService = new CateringCompanyService(unitofWork);
            cmbCampany.DataSource = companyService.GetAllCateringCompany().ToList();
            cmbCampany.ValueMember = "CompanyCode";
            cmbCampany.DisplayMember = "Name";
            #endregion
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            #region Firma Güncelleme İşlemi
            string newName = txtNewName.Text;
            string newDescriptions = txtNewDescriptions.Text;
            if (!string.IsNullOrEmpty(newName) && !string.IsNullOrEmpty(newDescriptions))
            {
                UnitofWork unitofWork = new UnitofWork(ctx);
                #region CateringCompany Güncelleme Yapılmaktadır.
                CateringCompanyService companyService = new CateringCompanyService(unitofWork);
                CateringCompany cateringCompany = companyService.GetCateringCompany(cmbCampany.SelectedValue.ToString());
                cateringCompany.Name = newName;
                cateringCompany.Descriptions = newDescriptions;
                companyService.Update(cateringCompany);
                #endregion

                #region CateringFoodDelivery Güncelleme İşlemi Yapmaktadır
                CateringFoodDeliveryService foodDeliveryService = new CateringFoodDeliveryService(unitofWork);
                List<CateringFoodDelivery> CateringFoodDeliveryList = foodDeliveryService.GetAllCateringFoodDelivery().Where(x => x.CompanyCode == cmbCampany.SelectedValue.ToString()).ToList();
                CateringFoodDeliveryList.ForEach(x =>
                {
                    x.Name = newName;
                    foodDeliveryService.Update(x);
                });
                #endregion

                #region CateringPayment Güncelleme İşlemi Yapmaktadır
                CateringPaymentService cateringPaymentService = new CateringPaymentService(unitofWork);
                List<CateringPayment> cateringPaymentList = cateringPaymentService.GetAllCateringPayment().Where(x => x.CompanyCode == cmbCampany.SelectedValue.ToString()).ToList();
                cateringPaymentList.ForEach(x =>
                {
                    x.Name = newName;
                    cateringPaymentService.Update(x);
                });
                #endregion

                #region CateringIncomeStatus Güncelleme İşlemi Yapmaktadır
                CateringIncomeStatusService cateringIncomeStatusService = new CateringIncomeStatusService(unitofWork);
                List<CateringIncomeStatus> cateringIncomeStatuseList = cateringIncomeStatusService.GetAllCateringIncomeStatus().Where(x => x.CompanyCode == cmbCampany.SelectedValue.ToString()).ToList();
                cateringIncomeStatuseList.ForEach(x =>
                {
                    x.Name = newName;
                    cateringIncomeStatusService.Update(x);
                });
                #endregion

                #region Güncelleme İşleminden Sonra Yapılanlar
                cmbCampany.DataSource = companyService.GetAllCateringCompany().ToList();
                cmbCampany.ValueMember = "CompanyCode";
                cmbCampany.DisplayMember = "Name";

                txtNewName.Text = "";
                txtNewDescriptions.Text = "";
                #endregion
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.");
            }
            #endregion
        }

        private void CmbCampany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            #region Combobox'dan Seçilen Degeri Textboxlara Basmaktadır.
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanyService companyService = new CateringCompanyService(unitofWork);
            CateringCompany cateringCompany = companyService.GetCateringCompany(cmbCampany.SelectedValue.ToString());
            txtNewName.Text = cateringCompany.Name;
            txtNewDescriptions.Text = cateringCompany.Descriptions;
            #endregion
        }


    }
}