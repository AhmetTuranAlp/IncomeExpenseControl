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
    public partial class CateringCompanyPaymentForm : Form
    {
        public CateringCompanyPaymentForm()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();

        #region Form Çalıştıgında Yapılan İşlemler
        private void CateringCompanyPayment_Load(object sender, EventArgs e)
        {
            #region Catering'ler Listelenmektedir.
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanyService companyService = new CateringCompanyService(unitofWork);
            List<CateringCompany> CateringCompanyList = new List<CateringCompany>();
            CateringCompanyList.Add(new CateringCompany() { CompanyCode = "", Name = "Firma Seçiniz..." });
            CateringCompanyList.AddRange(companyService.GetAllCateringCompany().ToList());
            cmbCampany.DataSource = CateringCompanyList;
            cmbCampany.ValueMember = "CompanyCode";
            cmbCampany.DisplayMember = "Name";
            #endregion
        }
        #endregion

        #region Catering Ödeme Yapıldıgında Yapılan İşlemler
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbCampany.SelectedValue.ToString()))
            {
                if (cmbCampany.SelectedValue != null && cmbServisDay.SelectedValue != null && nupPrice.Value > 0)
                {
                    string CompanyCode = cmbCampany.SelectedValue.ToString();
                    DateTime PaymentDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));
                    decimal Price = nupPrice.Value;
                    if (DateTime.Now > PaymentDate)
                    {
                        UnitofWork unitofWork = new UnitofWork(ctx);

                        #region Catering Ödemeler Kontrol Edilerek Eklenmektedir.
                        CateringPaymentService cateringPaymentService = new CateringPaymentService(unitofWork);
                        CateringPayment ExistingRecord = cateringPaymentService.GetCateringPayment(CompanyCode, PaymentDate);
                        if (ExistingRecord != null)
                        {
                            #region Var Olan Ödeme Kaydı Güncelleniyor.
                            ExistingRecord.Price += Price;
                            cateringPaymentService.Update(ExistingRecord);
                            #endregion
                        }
                        else
                        {
                            #region Yeni Kayıt Oluşturulurak Ödeme Yapılıyor.
                            CateringPayment cateringPayment = new CateringPayment();
                            cateringPayment.Name = cmbCampany.Text;
                            cateringPayment.CompanyCode = CompanyCode;
                            cateringPayment.PaymentDate = PaymentDate;
                            cateringPayment.Price = Price;
                            cateringPayment.Descriptions = txtDescriptions.Text;
                            cateringPaymentService.Insert(cateringPayment);
                            #endregion
                        }
                        #endregion

                        #region Hizmet Ödeme Durumunu True' ya çekiliyor.
                        CateringFoodDeliveryService foodDeliveryService = new CateringFoodDeliveryService(unitofWork);
                        CateringFoodDelivery cateringFoodDelivery = foodDeliveryService.GetCateringFoodDelivery(CompanyCode, Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", cmbServisDay.Text)));
                        if (cateringFoodDelivery != null && !string.IsNullOrEmpty(cateringFoodDelivery.CompanyCode))
                        {
                            cateringFoodDelivery.PaymentStatus = true;
                            foodDeliveryService.Update(cateringFoodDelivery);
                        }
                        #endregion

                        #region Ödeme İşleminden Sonra CateringIncomeStatus Tablosu Güncellenmektedir.
                        CateringIncomeStatusService cateringIncomeStatusService = new CateringIncomeStatusService(unitofWork);
                        CateringIncomeStatus IncomeStatusExistingRecord = cateringIncomeStatusService.GetCateringIncomeStatus(CompanyCode, PaymentDate);
                        if (!string.IsNullOrEmpty(IncomeStatusExistingRecord.CompanyCode))
                        {
                            IncomeStatusExistingRecord.TotalReceived += Price;
                            cateringIncomeStatusService.Update(IncomeStatusExistingRecord);

                            #region Toplam Gelir Tablosu Güncellenmektedir.
                            TotalRevenueService totalRevenueService = new TotalRevenueService(unitofWork);
                            TotalRevenue totalRevenueModel = totalRevenueService.GetSelectedTotalRevenueDay(RevenueType.Catering, Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now)));
                            if (totalRevenueModel != null)
                            {
                                totalRevenueModel.TotalPrice += Price;
                                totalRevenueService.Update(totalRevenueModel);
                            }
                            else
                            {
                                TotalRevenue totalRevenue = new TotalRevenue();
                                totalRevenue.Status = Status.Active;
                                totalRevenue.RevenueDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                                totalRevenue.RevenueType = RevenueType.Catering;
                                totalRevenue.TotalPrice = Price;
                                totalRevenueService.Insert(totalRevenue);
                            }
                            #endregion

                            MessageBox.Show("İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Ödeme Yapılamaz");
                        }
                        #endregion

                        
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
            else
            {
                MessageBox.Show("Firma Seçimi Yapınız");
            }
        }
        #endregion

        #region Catering Seçimi Yapıldıgında Yapılana İşlemler
        private void cmbCampany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbCampany.SelectedValue.ToString()))
            {
                UnitofWork unitofWork = new UnitofWork(ctx);
                CateringFoodDeliveryService foodDeliveryService = new CateringFoodDeliveryService(unitofWork);
                cmbServisDay.DataSource = foodDeliveryService.GetAllCateringFoodDelivery().Where(x => x.PaymentStatus == false && x.CompanyCode == cmbCampany.SelectedValue.ToString()).ToList();
                cmbServisDay.ValueMember = "CompanyCode";
                cmbServisDay.DisplayMember = "ServiceDate";
            }
        }
        #endregion
    }
}
