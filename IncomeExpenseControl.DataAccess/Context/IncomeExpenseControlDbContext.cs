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
            Database.Connection.ConnectionString = @"Server=AHMETTURANALP; Database=ElmasAnneEvYemekleriDB; Integrated Security=True;";
        }

        public virtual DbSet<Coder> Coder { get; set; }
        public virtual DbSet<CateringCompany> CateringCompany { get; set; }
        public virtual DbSet<CateringIncomeStatus> CateringIncomeStatus { get; set; }
        public virtual DbSet<CateringPayment> CateringPayment { get; set; }
        public virtual DbSet<CateringFoodDelivery> CateringService { get; set; }
        public virtual DbSet<CreditCards> CreditCards { get; set; }
        public virtual DbSet<FoodCards> FoodCards { get; set; }
        public virtual DbSet<RestaurantIncomeStatus> RestaurantIncomeStatus { get; set; }
        public virtual DbSet<RestaurantRevenues> RestaurantRevenues { get; set; }

    }   
}
