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
    public partial class CateringFoodDeliveryForm : Form
    {
        public CateringFoodDeliveryForm()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();

        #region Form Acıldıgında Anda Yapılacak İşlemler
        private void CateringFoodDelivery_Load(object sender, EventArgs e)
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

        #region Catering Hizmet Oluşturma İşlemleri
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbCampany.SelectedValue != null && nupNumberOfPeople.Value > 0 && nupPrice.Value > 0)
            {
                UnitofWork unitofWork = new UnitofWork(ctx);
                CateringFoodDeliveryService foodDeliveryService = new CateringFoodDeliveryService(unitofWork);

                string code = cmbCampany.SelectedValue.ToString();
                DateTime dateTime = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));
                if (DateTime.Now > dateTime)
                {
                    #region Yemek Servis Kontrol Edilerek Eklenmektedir.
                    CateringFoodDelivery ExistingRecord = foodDeliveryService.GetCateringFoodDelivery(code, dateTime);
                    if (ExistingRecord != null)
                    {
                        ExistingRecord.NumberOfPeople += Convert.ToInt32(nupNumberOfPeople.Value);
                        ExistingRecord.Price += nupPrice.Value;
                        ExistingRecord.PaymentStatus = false;
                        foodDeliveryService.Update(ExistingRecord);
                    }
                    else
                    {
                        CateringFoodDelivery cateringFoodDelivery = new CateringFoodDelivery();
                        cateringFoodDelivery.Name = cmbCampany.Text;
                        cateringFoodDelivery.CompanyCode = cmbCampany.SelectedValue.ToString();
                        cateringFoodDelivery.ServiceDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));
                        cateringFoodDelivery.NumberOfPeople = Convert.ToInt32(nupNumberOfPeople.Value);
                        cateringFoodDelivery.Price = nupPrice.Value;
                        cateringFoodDelivery.Descriptions = txtDescriptions.Text;
                        cateringFoodDelivery.PaymentStatus = false;
                        foodDeliveryService.Insert(cateringFoodDelivery);
                    }
                    #endregion

                    #region Yemek Servisi Sonrası CateringIncomeStatus Tablosunda Toplam Tutar ve Alacak Tutar Güncellenmektedir.
                    CateringIncomeStatusService cateringIncomeStatusService = new CateringIncomeStatusService(unitofWork);
                    List<CateringIncomeStatus> cateringIncomes = cateringIncomeStatusService.GetAllCateringIncomeStatus().Where(x => x.CompanyCode == code && x.RelatedMount == dateTime.Month).ToList();

                    if (cateringIncomes.Count() > 0)
                    {
                        if (cateringIncomes[0].RelatedMount == dateTime.Month)
                        {
                            cateringIncomes[0].TotalReceivables += nupPrice.Value;
                            cateringIncomeStatusService.Update(cateringIncomes[0]);
                        }
                        else
                        {
                            CateringIncomeStatus cateringIncomeStatus = new CateringIncomeStatus();
                            cateringIncomeStatus.Name = cmbCampany.Text;
                            cateringIncomeStatus.CompanyCode = code;
                            cateringIncomeStatus.RelatedMount = dateTime.Month;
                            cateringIncomeStatus.TotalReceivables = nupPrice.Value;
                            cateringIncomeStatusService.Insert(cateringIncomeStatus);
                        }
                    }
                    else
                    {
                        CateringIncomeStatus cateringIncomeStatus = new CateringIncomeStatus();
                        cateringIncomeStatus.Name = cmbCampany.Text;
                        cateringIncomeStatus.CompanyCode = code;
                        cateringIncomeStatus.RelatedMount = dateTime.Month;
                        cateringIncomeStatus.TotalReceivables = nupPrice.Value;
                        cateringIncomeStatusService.Insert(cateringIncomeStatus);
                    }
                    #endregion

                    MessageBox.Show("Kayıt Eklendi");
                }
                else
                {
                    MessageBox.Show("Zamanından Önce Yemek Servisi Yapılamaz");
                }
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.");
            }
        } 
        #endregion
    }
}
