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
    public partial class DailyCastingEntry_Restaurant_Cash_Form : Form
    {
        public DailyCastingEntry_Restaurant_Cash_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void BtnNewSave_Click(object sender, EventArgs e)
        {
            #region Variables
            DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
            decimal Price = nudPrice.Value;
            int NumberOfPeople = Convert.ToInt32(nudNumberOfPeople.Value);
            #endregion

            #region Service
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Restaurant_Cash_Service dailyCastingEntry_Restaurant_Cash_Service = new DailyCastingEntry_Restaurant_Cash_Service(unitofWork);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
            #endregion

            if (Price > 0 && NumberOfPeople > 0)
            {
                DailyCastingEntry_Restaurant_Cash dailyCastingEntry_Restaurant_Cash = new DailyCastingEntry_Restaurant_Cash()
                {
                    CastingDate = CastingDate,
                    NumberOfPeople = NumberOfPeople,
                    Price = Price,
                    Status = Status.Active
                };
                if (dailyCastingEntry_Restaurant_Cash_Service.Insert(dailyCastingEntry_Restaurant_Cash))
                {
                    DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                    if (dailyCastingEntry_TotalRevenue != null)
                    {
                        dailyCastingEntry_TotalRevenue.RestaurantCash_ReelPrice = dailyCastingEntry_TotalRevenue.RestaurantCash_ReelPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantCash_ReelPrice + Price : Price;

                        dailyCastingEntry_TotalRevenue.RestaurantCash_TotalPrice = dailyCastingEntry_TotalRevenue.RestaurantCash_TotalPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantCash_TotalPrice + Price : Price;

                        dailyCastingEntry_TotalRevenue.RestaurantCash_NumberOfPeople = dailyCastingEntry_TotalRevenue.RestaurantCash_NumberOfPeople > 0 ? dailyCastingEntry_TotalRevenue.RestaurantCash_NumberOfPeople + NumberOfPeople : NumberOfPeople;

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
                            RestaurantCash_NumberOfPeople = NumberOfPeople,
                            RestaurantCash_TotalPrice = Price,
                            RestaurantCash_ReelPrice = Price,
                            CastingDate = CastingDate
                        };

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
            else
            {
                MessageBox.Show("Boş Geçilemez.");
            }
        }
    }
}
