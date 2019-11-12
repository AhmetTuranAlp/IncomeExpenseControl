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
            //Database.Connection.ConnectionString = @"Server=DESKTOP-SUR4ILI; Database=ElmasAnneEvYemekleriDB; Integrated Security=True;";
        }

        public virtual DbSet<Coder> Coder { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<FoodCards> FoodCards { get; set; }
        public virtual DbSet<CateringCompanies> CateringCompanies { get; set; }
        public virtual DbSet<DailyCastingEntry_Catering> DailyCastingEntry_Catering { get; set; }
        public virtual DbSet<DailyCastingEntry_Personal> DailyCastingEntry_Personal { get; set; }
        public virtual DbSet<DailyCastingEntry_Restaurant_Bank> DailyCastingEntry_Restaurant_Bank { get; set; }
        public virtual DbSet<DailyCastingEntry_Restaurant_Cash> DailyCastingEntry_Restaurant_Cash { get; set; }
        public virtual DbSet<DailyCastingEntry_Restaurant_Food> DailyCastingEntry_Restaurant_Food { get; set; }
        public virtual DbSet<DailyCastingEntry_TotalRevenue> DailyCastingEntry_TotalRevenue { get; set; }
    }   
}
