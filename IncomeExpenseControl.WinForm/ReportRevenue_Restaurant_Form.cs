using IncomeExpenseControl.Common;
using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.Data.Entity;
using IncomeExpenseControl.Data.Model;
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
    public partial class ReportRevenue_Restaurant_Form : Form
    {
        public ReportRevenue_Restaurant_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void ReportRestaurant_Form_Load(object sender, EventArgs e)
        {
            EnumHelper enumHelper = new EnumHelper();
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Restaurant_Bank_Service dailyCastingEntry_Restaurant_Bank_Service = new DailyCastingEntry_Restaurant_Bank_Service(unitofWork);
            DailyCastingEntry_Restaurant_Cash_Service dailyCastingEntry_Restaurant_Cash_Service = new DailyCastingEntry_Restaurant_Cash_Service(unitofWork);
            DailyCastingEntry_Restaurant_Food_Service dailyCastingEntry_Restaurant_Food_Service = new DailyCastingEntry_Restaurant_Food_Service(unitofWork);

            List<DailyCastingEntry_Restaurant_Bank> dailyCastingEntry_Restaurant_Bank_List = dailyCastingEntry_Restaurant_Bank_Service.GetAllRestaurantBanksPaymentCasting();
            List<DailyCastingEntry_Restaurant_Cash> dailyCastingEntry_Restaurant_Cashes_List = dailyCastingEntry_Restaurant_Cash_Service.GetAllRestaurantCashPaymentCasting();
            List<DailyCastingEntry_Restaurant_Food> dailyCastingEntry_Restaurant_Foods_List = dailyCastingEntry_Restaurant_Food_Service.GetAllRestaurantFoodPaymentCasting();

            List<RestaurantRevenueVM> restaurantRevenueVMs = new List<RestaurantRevenueVM>();
            dailyCastingEntry_Restaurant_Bank_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.CreditCard);
                restaurantRevenueVM.Name = x.BankName;
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });

            dailyCastingEntry_Restaurant_Cashes_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.Cash);
                restaurantRevenueVM.Name = "";
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });

            dailyCastingEntry_Restaurant_Foods_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.FoodCard); ;
                restaurantRevenueVM.Name = x.FoodCardName;
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });
            dataGridView1.DataSource = restaurantRevenueVMs;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Ödeme Tipi";
            dataGridView1.Columns[2].HeaderText = "Kart Adı";
            dataGridView1.Columns[3].HeaderText = "Kişi Sayısı";
            dataGridView1.Columns[4].HeaderText = "Tutar";

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1,5);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.TransferringDatagridviewtoExcel(dataGridView1, Convert.ToDateTime(string.Format("{0: dd/MM/yyyy}", DateTime.Now)).ToString().Replace("00:00:00", "").Trim() + "_Restaurant Gelir");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EnumHelper enumHelper = new EnumHelper();
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Restaurant_Bank_Service dailyCastingEntry_Restaurant_Bank_Service = new DailyCastingEntry_Restaurant_Bank_Service(unitofWork);
            DailyCastingEntry_Restaurant_Cash_Service dailyCastingEntry_Restaurant_Cash_Service = new DailyCastingEntry_Restaurant_Cash_Service(unitofWork);
            DailyCastingEntry_Restaurant_Food_Service dailyCastingEntry_Restaurant_Food_Service = new DailyCastingEntry_Restaurant_Food_Service(unitofWork);

            List<DailyCastingEntry_Restaurant_Bank> dailyCastingEntry_Restaurant_Bank_List = dailyCastingEntry_Restaurant_Bank_Service.GetAllRestaurantBanksPaymentCasting();
            List<DailyCastingEntry_Restaurant_Cash> dailyCastingEntry_Restaurant_Cashes_List = dailyCastingEntry_Restaurant_Cash_Service.GetAllRestaurantCashPaymentCasting();
            List<DailyCastingEntry_Restaurant_Food> dailyCastingEntry_Restaurant_Foods_List = dailyCastingEntry_Restaurant_Food_Service.GetAllRestaurantFoodPaymentCasting();

            List<RestaurantRevenueVM> restaurantRevenueVMs = new List<RestaurantRevenueVM>();
            dailyCastingEntry_Restaurant_Bank_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.CreditCard);
                restaurantRevenueVM.Name = x.BankName;
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });

            dailyCastingEntry_Restaurant_Cashes_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.Cash);
                restaurantRevenueVM.Name = "";
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });

            dailyCastingEntry_Restaurant_Foods_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.FoodCard); ;
                restaurantRevenueVM.Name = x.FoodCardName;
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });
            dataGridView1.DataSource = restaurantRevenueVMs;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Ödeme Tipi";
            dataGridView1.Columns[2].HeaderText = "Kart Adı";
            dataGridView1.Columns[3].HeaderText = "Kişi Sayısı";
            dataGridView1.Columns[4].HeaderText = "Tutar";

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 5);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));

            EnumHelper enumHelper = new EnumHelper();
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Restaurant_Bank_Service dailyCastingEntry_Restaurant_Bank_Service = new DailyCastingEntry_Restaurant_Bank_Service(unitofWork);
            DailyCastingEntry_Restaurant_Cash_Service dailyCastingEntry_Restaurant_Cash_Service = new DailyCastingEntry_Restaurant_Cash_Service(unitofWork);
            DailyCastingEntry_Restaurant_Food_Service dailyCastingEntry_Restaurant_Food_Service = new DailyCastingEntry_Restaurant_Food_Service(unitofWork);

            List<DailyCastingEntry_Restaurant_Bank> dailyCastingEntry_Restaurant_Bank_List = dailyCastingEntry_Restaurant_Bank_Service.GetAllRestaurantBanksPaymentCasting().Where(x => x.CastingDate == CastingDate).ToList();
            List<DailyCastingEntry_Restaurant_Cash> dailyCastingEntry_Restaurant_Cashes_List = dailyCastingEntry_Restaurant_Cash_Service.GetAllRestaurantCashPaymentCasting().Where(x => x.CastingDate == CastingDate).ToList();
            List<DailyCastingEntry_Restaurant_Food> dailyCastingEntry_Restaurant_Foods_List = dailyCastingEntry_Restaurant_Food_Service.GetAllRestaurantFoodPaymentCasting().Where(x => x.CastingDate == CastingDate).ToList();

            List<RestaurantRevenueVM> restaurantRevenueVMs = new List<RestaurantRevenueVM>();
            dailyCastingEntry_Restaurant_Bank_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.CreditCard);
                restaurantRevenueVM.Name = x.BankName;
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });

            dailyCastingEntry_Restaurant_Cashes_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.Cash);
                restaurantRevenueVM.Name = "";
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });

            dailyCastingEntry_Restaurant_Foods_List.ForEach(x =>
            {
                RestaurantRevenueVM restaurantRevenueVM = new RestaurantRevenueVM();
                restaurantRevenueVM.CastingDate = x.CastingDate;
                restaurantRevenueVM.PaymentType = enumHelper.GetEnumDescription(PaymentType.FoodCard); ;
                restaurantRevenueVM.Name = x.FoodCardName;
                restaurantRevenueVM.NumberOfPeople = x.NumberOfPeople;
                restaurantRevenueVM.Price = x.Price;
                restaurantRevenueVMs.Add(restaurantRevenueVM);
            });
            dataGridView1.DataSource = restaurantRevenueVMs;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Ödeme Tipi";
            dataGridView1.Columns[2].HeaderText = "Kart Adı";
            dataGridView1.Columns[3].HeaderText = "Kişi Sayısı";
            dataGridView1.Columns[4].HeaderText = "Tutar";

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 5);
        }
    }
}
