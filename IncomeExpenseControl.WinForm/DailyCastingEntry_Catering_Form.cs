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
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.WinForm
{
    public partial class DailyCastingEntry_Catering_Form : Form
    {
        public DailyCastingEntry_Catering_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void DailyCastingEntry_Catering_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanies_Service cateringCompanies_Service = new CateringCompanies_Service(unitofWork);
            cmbNewCateringCustomers.DataSource = cateringCompanies_Service.GetAllCateringCompanies();
            cmbNewCateringCustomers.DisplayMember = "Name";
            cmbNewCateringCustomers.ValueMember = "Code";

            cmbOldCateringCompany.DataSource = cateringCompanies_Service.GetAllCateringCompanies();
            cmbOldCateringCompany.DisplayMember = "Name";
            cmbOldCateringCompany.ValueMember = "Code";
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            #region Variables
            DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
            decimal Price = nudPrice.Value;
            int NumberOfPeople = Convert.ToInt32(nudNumberOfPeople.Value);
            string CateringCode = cmbNewCateringCustomers.SelectedValue.ToString();
            #endregion

            #region Service Instance
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanies_Service cateringCompanies_Service = new CateringCompanies_Service(unitofWork);
            DailyCastingEntry_Catering_Service dailyCastingEntry_Catering_Service = new DailyCastingEntry_Catering_Service(unitofWork);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork); 
            #endregion

            DailyCastingEntry_Catering dailyCastingEntry_Catering = dailyCastingEntry_Catering_Service.GetCateringPaymentCasting(CastingDate, CateringCode);
            if (dailyCastingEntry_Catering != null)
            {

            }
            else
            {
                #region DailyCastingEntry_Catering Modeli Dolduruluyor
                dailyCastingEntry_Catering = new DailyCastingEntry_Catering()
                {
                    CastingDate = CastingDate,
                    CateringCompany = cateringCompanies_Service.GetCateringCompanies(CateringCode),
                    NumberOfPeople = NumberOfPeople,
                    Price = Price,
                    Status = Status.Active,
                };
                if (cmbPaymentStatus.SelectedText == "Yapıldı")
                {
                    dailyCastingEntry_Catering.PaymentMade = true;
                }
                else if (cmbPaymentStatus.SelectedText == "Yapılmadı")
                {
                    dailyCastingEntry_Catering.PaymentMade = false;
                }

                if (rbInvoiceFalse.Checked)
                {
                    dailyCastingEntry_Catering.InvoiceCut = true;
                }
                else
                {
                    dailyCastingEntry_Catering.InvoiceCut = false;
                }
                #endregion

                if (dailyCastingEntry_Catering_Service.Insert(dailyCastingEntry_Catering))
                {
                    DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                    if (dailyCastingEntry_TotalRevenue != null)
                    {
                        #region DailyCastingEntry_TotalRevenue Modelinde Catering Bilgileri Güncellenir.
                        #region Catering_TotalPrice
                        if (dailyCastingEntry_TotalRevenue.Catering_TotalPrice > 0)
                        {
                            dailyCastingEntry_TotalRevenue.Catering_TotalPrice += Price;
                        }
                        else
                        {
                            dailyCastingEntry_TotalRevenue.Catering_TotalPrice = Price;
                        }
                        #endregion

                        #region Catering_ReelPrice
                        if (dailyCastingEntry_TotalRevenue.Catering_ReelPrice > 0)
                        {
                            dailyCastingEntry_TotalRevenue.Catering_ReelPrice += Price;
                        }
                        else
                        {
                            dailyCastingEntry_TotalRevenue.Catering_ReelPrice = Price;
                        }
                        #endregion

                        #region Catering_NumberOfPeople
                        if (dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople > 0)
                        {
                            dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople += NumberOfPeople;
                        }
                        else
                        {
                            dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople = NumberOfPeople;
                        }
                        #endregion

                        if (dailyCastingEntry_TotalRevenue_Service.Update(dailyCastingEntry_TotalRevenue))
                        {
                            MessageBox.Show("İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız");
                        } 
                        #endregion
                    }
                    else
                    {
                        #region DailyCastingEntry_TotalRevenue Yeni Kayıt Oluşturuluyor ve Catering Bilgileri Ekleniyor.
                        dailyCastingEntry_TotalRevenue = new DailyCastingEntry_TotalRevenue();
                        dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople = NumberOfPeople;
                        dailyCastingEntry_TotalRevenue.Catering_TotalPrice = Price;
                        if (cmbPaymentStatus.SelectedText == "Yapıldı")
                        {
                            dailyCastingEntry_TotalRevenue.Catering_ReelPrice = Price;
                        }

                        if (dailyCastingEntry_TotalRevenue_Service.Insert(dailyCastingEntry_TotalRevenue))
                        {
                            MessageBox.Show("İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız");
                        } 
                        #endregion
                    }
                }
            }
        }
    }
}
