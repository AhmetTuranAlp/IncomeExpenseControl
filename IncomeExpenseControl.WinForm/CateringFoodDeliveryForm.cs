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
        private void CateringFoodDelivery_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanyService companyService = new CateringCompanyService(unitofWork);
            cmbCampany.DataSource = companyService.GetAllCateringCompany().ToList();
            cmbCampany.ValueMember = "CompanyCode";
            cmbCampany.DisplayMember = "Name";

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringFoodDeliveryService foodDeliveryService = new CateringFoodDeliveryService(unitofWork);
            CateringFoodDelivery cateringFoodDelivery = new CateringFoodDelivery();
            cateringFoodDelivery.Name = cmbCampany.Text;
            cateringFoodDelivery.CompanyCode = cmbCampany.SelectedValue.ToString();
            cateringFoodDelivery.ServiceDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));
            cateringFoodDelivery.NumberOfPeople = Convert.ToInt32(nupNumberOfPeople.Value);
            cateringFoodDelivery.Price = nupPrice.Value;
            cateringFoodDelivery.Descriptions = txtDescriptions.Text;
            if (foodDeliveryService.Insert(cateringFoodDelivery))
            {
                CateringIncomeStatusService cateringIncomeStatusService = new CateringIncomeStatusService(unitofWork);
                string code = cmbCampany.SelectedValue.ToString();
                DateTime dateTime = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));

                List<CateringIncomeStatus> cateringIncomes = cateringIncomeStatusService.GetAllCateringIncomeStatus().Where(x => x.CompanyCode == code && x.RelatedDay == dateTime).ToList();

                if (cateringIncomes.Count() > 0)
                {
                    if (cateringIncomes[0].RelatedDay == dateTime)
                    {
                        cateringIncomes[0].TotalReceivables += nupPrice.Value;
                        cateringIncomeStatusService.Update(cateringIncomes[0]);
                    }
                    else
                    {
                        CateringIncomeStatus cateringIncomeStatus = new CateringIncomeStatus();
                        cateringIncomeStatus.Name = cmbCampany.Text;
                        cateringIncomeStatus.CompanyCode = code;
                        cateringIncomeStatus.RelatedDay = dateTime;
                        cateringIncomeStatus.TotalReceivables = nupPrice.Value;
                        cateringIncomeStatusService.Insert(cateringIncomeStatus);
                    }
                }
                else
                {
                    CateringIncomeStatus cateringIncomeStatus = new CateringIncomeStatus();
                    cateringIncomeStatus.Name = cmbCampany.Text;
                    cateringIncomeStatus.CompanyCode = code;
                    cateringIncomeStatus.RelatedDay = dateTime;
                    cateringIncomeStatus.TotalReceivables = nupPrice.Value;
                    cateringIncomeStatusService.Insert(cateringIncomeStatus);
                }
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
                MessageBox.Show("Hata Oluştu.");
            }
        }
    }
}
