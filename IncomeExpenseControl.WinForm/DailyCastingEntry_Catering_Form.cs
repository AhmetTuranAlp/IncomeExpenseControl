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


            List<CateringCompanies> CateringCompanyList = new List<CateringCompanies>();
            CateringCompanyList.Add(new CateringCompanies() { Code = "", Name = "Firma Seçiniz..." });
            CateringCompanyList.AddRange(cateringCompanies_Service.GetAllCateringCompanies());


            cmbNewCateringCustomers.DataSource = CateringCompanyList;
            cmbNewCateringCustomers.DisplayMember = "Name";
            cmbNewCateringCustomers.ValueMember = "Code";

            cmbOldCateringCompany.DataSource = CateringCompanyList;
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
            bool PaymentMade = cmbPaymentStatus.Text == "Yapıldı" ? true : false;
            bool InvoiceCut = cmbInvoice.Text == "Kesildi" ? true : false;

            #endregion

            #region Service Instance
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanies_Service cateringCompanies_Service = new CateringCompanies_Service(unitofWork);
            DailyCastingEntry_Catering_Service dailyCastingEntry_Catering_Service = new DailyCastingEntry_Catering_Service(unitofWork);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
            #endregion

            if (Price > 0 && NumberOfPeople > 0 && !string.IsNullOrEmpty(CateringCode) && !string.IsNullOrEmpty(cmbInvoice.Text) && !string.IsNullOrEmpty(cmbPaymentStatus.Text))
            {
                DailyCastingEntry_Catering dailyCastingEntry_Catering = new DailyCastingEntry_Catering()
                {
                    CastingDate = CastingDate,
                    CateringCompany = cateringCompanies_Service.GetCateringCompanies(CateringCode),
                    NumberOfPeople = NumberOfPeople,
                    Price = Price,
                    Status = Status.Active,
                    PaymentMade = PaymentMade,
                    InvoiceCut = InvoiceCut
                };
                if (dailyCastingEntry_Catering_Service.Insert(dailyCastingEntry_Catering))
                {
                    DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                    if (dailyCastingEntry_TotalRevenue != null)
                    {
                        if (PaymentMade)
                        {
                            dailyCastingEntry_TotalRevenue.Catering_ReelPrice = dailyCastingEntry_TotalRevenue.Catering_ReelPrice > 0 ? dailyCastingEntry_TotalRevenue.Catering_ReelPrice + Price : Price;
                        }
                        dailyCastingEntry_TotalRevenue.Catering_TotalPrice = dailyCastingEntry_TotalRevenue.Catering_TotalPrice > 0 ? dailyCastingEntry_TotalRevenue.Catering_TotalPrice + Price : Price;
                 
                        dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople = dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople > 0 ? dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople + NumberOfPeople : NumberOfPeople;

                        if (dailyCastingEntry_TotalRevenue_Service.Update(dailyCastingEntry_TotalRevenue))
                        {
                            MessageBox.Show("İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız");
                        }
                    }
                    else
                    {
                        #region DailyCastingEntry_TotalRevenue Yeni Kayıt Oluşturuluyor ve Catering Bilgileri Ekleniyor.
                        dailyCastingEntry_TotalRevenue = new DailyCastingEntry_TotalRevenue
                        {
                            CastingDate = CastingDate,
                            Catering_NumberOfPeople = NumberOfPeople,
                            Catering_TotalPrice = Price,
                            Catering_ReelPrice = PaymentMade == true ? Price : 0
                        };

                        if (dailyCastingEntry_TotalRevenue_Service.Insert(dailyCastingEntry_TotalRevenue))
                        {
                            MessageBox.Show("İşlem Başarılı.");
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.");
                        }
                        #endregion
                    }

                    nudPrice.Value = 0;
                    nudNumberOfPeople.Value = 0;
                    cmbNewCateringCustomers.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.");
                }
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.");
            }


        }
    }
}
