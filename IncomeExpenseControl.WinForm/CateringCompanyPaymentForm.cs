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
    public partial class CateringCompanyPaymentForm : Form
    {
        public CateringCompanyPaymentForm()
        {
            InitializeComponent();
        }
        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void CateringCompanyPayment_Load(object sender, EventArgs e)
        {
            #region Catering'ler Listelenmektedir.
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanyService companyService = new CateringCompanyService(unitofWork);
            cmbCampany.DataSource = companyService.GetAllCateringCompany().ToList();
            cmbCampany.ValueMember = "CompanyCode";
            cmbCampany.DisplayMember = "Name"; 
            #endregion
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
       
            if (cmbCampany.SelectedValue != null && nupPrice.Value > 0)
            {
                string CompanyCode = cmbCampany.SelectedValue.ToString();
                DateTime PaymentDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));
                decimal Price = nupPrice.Value;
                if (DateTime.Now > PaymentDate)
                {
                    UnitofWork unitofWork = new UnitofWork(ctx);
                    CateringPaymentService cateringPaymentService = new CateringPaymentService(unitofWork);

                    #region Caterin Ödemeler Kontrol Edilerek Eklenmektedir.
                    CateringPayment ExistingRecord = cateringPaymentService.GetCateringPayment(CompanyCode, PaymentDate);
                    if (ExistingRecord != null)
                    {
                        ExistingRecord.Price += Price;
                        cateringPaymentService.Update(ExistingRecord);
                    }
                    else
                    {
                        CateringPayment cateringPayment = new CateringPayment();
                        cateringPayment.Name = cmbCampany.Text;
                        cateringPayment.CompanyCode = CompanyCode;
                        cateringPayment.PaymentDate = PaymentDate;
                        cateringPayment.Price = Price;
                        cateringPayment.Descriptions = txtDescriptions.Text;
                        cateringPaymentService.Insert(cateringPayment);
                    }
                    #endregion

                    CateringIncomeStatusService cateringIncomeStatusService = new CateringIncomeStatusService(unitofWork);
                    CateringIncomeStatus IncomeStatusExistingRecord = cateringIncomeStatusService.GetCateringIncomeStatus(CompanyCode, PaymentDate);
                    if (IncomeStatusExistingRecord != null)
                    {
                        #region Ödeme İşleminden Sonra CateringIncomeStatus Tablosu Güncellenmektedir.
                        IncomeStatusExistingRecord.TotalReceived += Price;
                        cateringIncomeStatusService.Update(IncomeStatusExistingRecord);
                        #endregion

                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Ödeme Yapılamaz");
                    }
                }
                else
                {
                    MessageBox.Show("Zamanından Önce Ödeme Yapılamaz");
                }
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.");
            }
            
        }
    }
}
