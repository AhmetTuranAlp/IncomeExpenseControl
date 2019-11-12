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
    public partial class DailyCastingEntry_Restaurant_Bank_Form : Form
    {
        public DailyCastingEntry_Restaurant_Bank_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void DailyCastingEntry_Restaurant_Bank_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            Banks_Service banks_Service = new Banks_Service(unitofWork);

            List<Banks> bankList = new List<Banks>();
            bankList.Add(new Banks() { BankCode = "", BankName = "Banka Seçiniz..." });
            bankList.AddRange(banks_Service.GetAllBanks());

            cmbBanks.DataSource = bankList;
            cmbBanks.DisplayMember = "BankName";
            cmbBanks.ValueMember = "BankCode";
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            #region Variables
            DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
            string BankName = cmbBanks.Text;
            string BankCode = cmbBanks.SelectedValue.ToString();
            decimal Price = nudPrice.Value;
            int NumberOfPeople = Convert.ToInt32(nudNumberOfPeople.Value);
            #endregion

            #region Services
            UnitofWork unitofWork = new UnitofWork(ctx);
            Banks_Service banks_Service = new Banks_Service(unitofWork);
            DailyCastingEntry_Restaurant_Bank_Service dailyCastingEntry_Restaurant_Bank_Service = new DailyCastingEntry_Restaurant_Bank_Service(unitofWork);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
            #endregion

            if (!string.IsNullOrEmpty(BankCode) && Price > 0 && NumberOfPeople > 0)
            {
                DailyCastingEntry_Restaurant_Bank dailyCastingEntry_Restaurant_Bank = new DailyCastingEntry_Restaurant_Bank()
                {
                    Banks = banks_Service.GetBanks(BankCode),
                    CastingDate = CastingDate,
                    NumberOfPeople = NumberOfPeople,
                    Price = Price,
                    Status = Status.Active
                };
                if (dailyCastingEntry_Restaurant_Bank_Service.Insert(dailyCastingEntry_Restaurant_Bank))
                {
                    DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                    if (dailyCastingEntry_TotalRevenue != null)
                    {
                        dailyCastingEntry_TotalRevenue.RestaurantBank_ReelPrice = dailyCastingEntry_TotalRevenue.RestaurantBank_ReelPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantBank_ReelPrice + Price : Price;

                        dailyCastingEntry_TotalRevenue.RestaurantBank_TotalPrice = dailyCastingEntry_TotalRevenue.RestaurantBank_TotalPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantBank_TotalPrice + Price : Price;

                        dailyCastingEntry_TotalRevenue.RestaurantBank_NumberOfPeople = dailyCastingEntry_TotalRevenue.RestaurantBank_NumberOfPeople > 0 ? dailyCastingEntry_TotalRevenue.RestaurantBank_NumberOfPeople + NumberOfPeople : NumberOfPeople;

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
                        dailyCastingEntry_TotalRevenue = new DailyCastingEntry_TotalRevenue();
                        dailyCastingEntry_TotalRevenue.RestaurantBank_NumberOfPeople = NumberOfPeople;
                        dailyCastingEntry_TotalRevenue.RestaurantBank_TotalPrice = Price;
                        dailyCastingEntry_TotalRevenue.RestaurantBank_ReelPrice = Price;

                        if (dailyCastingEntry_TotalRevenue_Service.Insert(dailyCastingEntry_TotalRevenue))
                        {
                            MessageBox.Show("İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız");
                        }
                    }
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
