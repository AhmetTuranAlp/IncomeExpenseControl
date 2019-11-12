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
    public partial class DailyCastingEntry_Restaurant_Food_Form : Form
    {
        public DailyCastingEntry_Restaurant_Food_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void DailyCastingEntry_Restaurant_Food_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            FoodCards_Service foodCards_Service = new FoodCards_Service(unitofWork);

            List<FoodCards> foodCardsList = new List<FoodCards>();
            foodCardsList.Add(new FoodCards() { Code = "", Name = "Yemek Kartı Seçiniz..." });
            foodCardsList.AddRange(foodCards_Service.GetAllFoodCards());

            cmbFoods.DataSource = foodCardsList;
            cmbFoods.DisplayMember = "Name";
            cmbFoods.ValueMember = "Code";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
            string Name = cmbFoods.Text;
            string Code = cmbFoods.SelectedValue.ToString();
            decimal Price = nudPrice.Value;
            int NumberOfPeople = Convert.ToInt32(nudNumberOfPeople.Value);
            #endregion

            #region Services
            UnitofWork unitofWork = new UnitofWork(ctx);
            FoodCards_Service foodCards_Service = new FoodCards_Service(unitofWork);
            DailyCastingEntry_Restaurant_Food_Service dailyCastingEntry_Restaurant_Food_Service = new DailyCastingEntry_Restaurant_Food_Service(unitofWork);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
            #endregion

            if (!string.IsNullOrEmpty(Code) && Price > 0 && NumberOfPeople > 0)
            {
                DailyCastingEntry_Restaurant_Food dailyCastingEntry_Restaurant_Food = new DailyCastingEntry_Restaurant_Food()
                {
                    FoodCards = foodCards_Service.GetFoodCards(Code),
                    CastingDate = CastingDate,
                    NumberOfPeople = NumberOfPeople,
                    Price = Price,
                    Status = Status.Active
                };
                if (dailyCastingEntry_Restaurant_Food_Service.Insert(dailyCastingEntry_Restaurant_Food))
                {
                    DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                    if (dailyCastingEntry_TotalRevenue != null)
                    {
                        dailyCastingEntry_TotalRevenue.RestaurantFood_ReelPrice = dailyCastingEntry_TotalRevenue.RestaurantFood_ReelPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantFood_ReelPrice + Price : Price;

                        dailyCastingEntry_TotalRevenue.RestaurantFood_TotalPrice = dailyCastingEntry_TotalRevenue.RestaurantFood_TotalPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantFood_TotalPrice + Price : Price;

                        dailyCastingEntry_TotalRevenue.RestaurantFood_NumberOfPeople = dailyCastingEntry_TotalRevenue.RestaurantFood_NumberOfPeople > 0 ? dailyCastingEntry_TotalRevenue.RestaurantFood_NumberOfPeople + NumberOfPeople : NumberOfPeople;

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
                        dailyCastingEntry_TotalRevenue.RestaurantFood_NumberOfPeople = NumberOfPeople;
                        dailyCastingEntry_TotalRevenue.RestaurantFood_TotalPrice = Price;
                        dailyCastingEntry_TotalRevenue.RestaurantFood_ReelPrice = Price;

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
