using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Context
{
    public class IncomeExpenseControlDbContext : DbContext
    {
        public IncomeExpenseControlDbContext() : base("IncomeExpenseControlDbContext")
        {
            //Veritabanı Yoksa Yeni Bir Veritabanı Oluşturur.
            Database.SetInitializer<IncomeExpenseControlDbContext>(new CreateDatabaseIfNotExists<IncomeExpenseControlDbContext>());
            //Değişiklik Oldugu Taktirde İçerikler ile Beraber Veritabanını Drop Etmektedir.
            Database.SetInitializer<IncomeExpenseControlDbContext>(new DropCreateDatabaseIfModelChanges<IncomeExpenseControlDbContext>());
            //ConnString Belirleniyor.
            Database.Connection.ConnectionString = @"Server=DESKTOP-SUR4ILI; Database=ElmasAnneEvYemekleriDB; Integrated Security=True;";
        }

        public DbSet<CateringCompany> CateringCompany { get; set; }
        public DbSet<CateringIncomeStatus> CateringIncomeStatus { get; set; }
        public DbSet<CateringPayment> CateringPayment { get; set; }
        public DbSet<CateringFoodDelivery> CateringService { get; set; }
        public DbSet<CreditCards> CreditCards { get; set; }
        public DbSet<FoodCards> FoodCards { get; set; }
        public DbSet<RestaurantIncomeStatus> RestaurantIncomeStatus { get; set; }
        public DbSet<RestaurantRevenues> RestaurantRevenues { get; set; }

    }   
}
